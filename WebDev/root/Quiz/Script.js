
let CheckBoxInput = document.getElementsByName("c1");
let button = document.getElementById("btn")
for (let i = 0; i < CheckBoxInput.length; i++)
{
    CheckBoxInput[i].addEventListener("change", () => {
        //console.log(i);
        for (let i = 0; i < CheckBoxInput.length; i++)
        {
            
            
            console.log(CheckBoxInput[i].checked)
            if (CheckBoxInput[i].checked == true)
            {
                button.disabled = false;
                //button.setAttribute("disabled", false);
            }
            else
            {
                button.disabled = true;
            }
            
        }
        
    })
}