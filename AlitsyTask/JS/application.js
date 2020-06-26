
function calculateRate(chargeElement, quantityElement) {

    let charge = document.getElementById(chargeElement).value;
    let quantity = document.getElementById(quantityElement).value;

    if (charge && quantity) {
        return (charge / quantity).toFixed(5);
    }
}
function updatePeakER() {
    
    let val = calculateRate("peakCharge", "peakQuantity");
    document.getElementById("peakEnergyRate").value = val ? val : "";
}

function updateShoulderER() {

   
    let val = calculateRate("shoulderCharge", "shoulderQuantity");
    document.getElementById("shoulderEnergyRate").value = val ? val : "";
}
function updateOffPeakER() {

  
    let val = calculateRate("offPeakCharge", "offPeakQuantity")
    document.getElementById("offPeakEnergyRate").value = val ? val : "";

}
