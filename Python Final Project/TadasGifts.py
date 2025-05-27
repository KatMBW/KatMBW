from breezypythongui import EasyFrame
from tkinter.messagebox import showinfo

class OrderFormApp(EasyFrame):
    def __init__(self):
        EasyFrame.__init__(self, title="Tada's Gifts Order App")
        self.setBackground("purple")

        # Define items and their base prices
        self.items = {
            "T-Shirt": {"price": 20},
            "Jacket": {"price": 25},
            "Cup": {"price": 25},
            "Car Decal": {"price": 20},
            "Hat": {"price": 15},
            "Sticker": {"price": 10},
        }

        # Initialize totals
        self.total_price = 0.0
        self.tax = 0.0
        self.shipping_cost = 0.0

        # Add item selection widgets dynamically
        self.addLabel(text = "Items", row = 0, column = 0)
        self.addLabel(text = "Quantity", row = 0, column = 1)
        self.addLabel(text = "Design", row = 0, column = 2)
        
        self.checkbuttons = {}
        self.quantity_fields = {}
        self.design_fields = {}

        for i, (item, details) in enumerate(self.items.items(), start = 1):
            self.checkbuttons[item] = self.addCheckbutton(row = i, column = 0, text = item)
            self.quantity_fields[item] = self.addIntegerField(value = 0, row = i, column = 1)
            self.design_fields[item] = self.addTextField(text = "", row = i, column = 2)

        # Add available designs listbox
        self.addLabel(text = "Designs Available:", row = 0, column = 3)
        self.designList = self.addListbox(row = 1, column = 3, rowspan = 6)
        available_designs = [
            "Disney", "Supernatural", "Looney Toons", "Scooby-Doo", "Religious",
            "Valentine's Day", "St. Patrick's Day", "Easter", "Independence Day",
            "Halloween", "Thanksgiving", "Christmas", "Birthday", "Horror", "Funny Saying"
        ]
        for design in available_designs:
            self.designList.insert("end", design)

        # Size selector setup
        self.sizeLabel = self.addLabel(text = "Size:", row = 0, column = 4)
        self.smallCB = self.addCheckbutton(text = "Small", row = 1, column = 4)
        self.mediumCB = self.addCheckbutton(text = "Medium", row = 2, column = 4)
        self.largeCB = self.addCheckbutton(text = "Large", row = 3, column = 4)
        self.xlCB = self.addCheckbutton(text = "1XL", row = 4, column = 4)
        self.xxlCB = self.addCheckbutton(text = "2XL", row = 5, column = 4)
        self.xxxlCB = self.addCheckbutton(text = "3XL", row = 6, column = 4)
        self.xxxxlCB = self.addCheckbutton(text = "4XL", row = 7, column = 4)
        self.xxxxxlCB = self.addCheckbutton(text = "5XL", row = 8, column = 4)


        # Note/comment setup
        self.notesLabel = self.addLabel(text = "Notes/Comments:", row = 7, column = 3)
        self.notesTextArea = self.addTextArea(text = "", row = 8, column = 3)

        # Shipping details
        self.addLabel(text = "Do you need this order shipped?", row = 7, column = 0, columnspan = 2)
        self.shippingYN = self.addRadiobuttonGroup(row = 7, column = 2, rowspan = 2)
        self.yesButton = self.shippingYN.addRadiobutton("Yes")
        self.noButton = self.shippingYN.addRadiobutton("No")
        self.shippingYN.setSelectedButton(self.noButton)

        self.addLabel(text = "Street:", row = 9, column = 0)
        self.streetTB = self.addTextField(text = "", row = 9, column = 1)
        self.addLabel(text = "City:", row = 10, column = 0)
        self.cityTB = self.addTextField(text = "", row = 10, column = 1)
        self.addLabel(text = "State:", row = 11, column = 0)
        self.zipTB = self.addTextField(text = "", row = 11, column = 1)
        self.addLabel(text = "ZIP:", row = 12, column = 0)
        self.zipTB = self.addIntegerField(value = 0, row = 12, column = 1)
 
        # Totals
        self.addLabel(text = "Total:", row = 13, column = 0)
        self.totalLabel = self.addLabel(text = "", row = 13, column = 1)
        self.addLabel(text = "Tax (7%):", row = 14, column = 0)
        self.taxLabel = self.addLabel(text = "", row = 14, column = 1)
        self.addLabel(text = "Shipping:", row = 15, column = 0)
        self.shippingLabel = self.addLabel(text = "", row = 15, column = 1)
        self.addLabel(text = "Grand Total:", row = 16, column = 0)
        self.grandTotalLabel = self.addLabel(text = "", row = 16, column = 1)

        # Buttons
        self.addButton(text = "Place Order", row = 17, column = 0, command = self.placeOrder)
        self.addButton(text = "Cancel", row = 17, column = 1, command = self.cancelOrder)

    def calculateTotals(self):
    
        self.total_price = 0.0
        for item, details in self.items.items():
            if self.checkbuttons[item].isChecked():
                quantity = self.quantity_fields[item].getNumber()
                self.total_price += details["price"] * quantity

        self.tax = self.total_price * 0.07
    
        shipping_selection = self.shippingYN.getSelectedButton()
        if shipping_selection == self.yesButton:
            self.shipping_cost = 6.99
        else:
            self.shipping_cost = 0.0

        grand_total = self.total_price + self.tax + self.shipping_cost

        # Update labels
        self.totalLabel["text"] = f"${self.total_price:.2f}"
        self.taxLabel["text"] = f"${self.tax:.2f}"
        self.shippingLabel["text"] = f"${self.shipping_cost:.2f}"
        self.grandTotalLabel["text"] = f"${grand_total:.2f}"

    def saveToFile(self):
        
        try:
            with open("Order.txt", "w") as file:
                file.write("Order Summary\n")
                file.write("=" * 40 + "\n")

                file.write("Items Ordered:\n")
                for item, details in self.items.items():
                    if self.checkbuttons[item].isChecked():
                        quantity = self.quantity_fields[item].getNumber()
                        design = self.design_fields[item].getText()
                        file.write(f"- {item}: Quantity = {quantity}, Design = {design}\n")
                file.write("\nSelected Sizes:\n")
                sizes = []
                if self.smallCB.isChecked(): sizes.append("Small")
                if self.mediumCB.isChecked(): sizes.append("Medium")
                if self.largeCB.isChecked(): sizes.append("Large")
                if self.xlCB.isChecked(): sizes.append("1XL")
                if self.xxlCB.isChecked(): sizes.append("2XL")
                if self.xxxlCB.isChecked(): sizes.append("3XL")
                if self.xxxxlCB.isChecked(): sizes.append("4XL")
                if self.xxxxxlCB.isChecked(): sizes.append("5XL")
                if sizes:
                    file.write(", ".join(sizes) + "\n")
                else:
                    file.write("No size selected\n")

                notes = self.notesTextArea.getText()
                file.write("\nNotes/Comments:\n")
                file.write(notes.strip() if notes.strip() else "No comments provided\n")

                file.write("\nShipping Details:\n")
                if self.shippingYN.getSelectedButton() == self.yesButton:
                    file.write(f"Street: {self.streetTB.getText()}\n")
                    file.write(f"City: {self.cityTB.getText()}\n")
                    file.write(f"ZIP: {self.zipTB.getNumber()}\n")
                else:
                    file.write("Shipping: Local pickup. No shipping information.\n")

                self.calculateTotals()
                file.write("\nOrder Totals:\n")
                file.write(f"Total: ${self.total_price:.2f}\n")
                file.write(f"Tax: ${self.tax:.2f}\n")
                file.write(f"Shipping: ${self.shipping_cost:.2f}\n")
                file.write(f"Grand Total: ${self.total_price + self.tax + self.shipping_cost:.2f}\n")

                self.messageBox(title="Success", message="Order saved to Order.txt!")
        except Exception as e:
            self.messageBox(title="Error", message=f"An error occurred: {e}")

    def placeOrder(self):
        self.calculateTotals()
        showinfo("Order Confirmation", "Your order has been placed! We will contact you directly for payment. Thank you.")
        self.saveToFile()

    def cancelOrder(self):
        showinfo("Order Cancelled", "Your order has been cancelled. You may now close the Order app.")

if __name__ == "__main__":
    OrderFormApp().mainloop()
