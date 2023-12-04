using System.Threading.Channels;

namespace FactoryMethod
{
    public interface Button
    {
        public void onClick();

        public void render();
    }


    public class WindowsButton : Button
    {
        public void onClick()
        {
            Console.WriteLine("Windows Button click");
        }

        public void render()
        {
            Console.WriteLine("Windows Button render");
        }
    }

    public class HTMLButton : Button
    {
        public void onClick()
        {
            Console.WriteLine("HTML Button click");
        }

        public void render()
        {
            Console.WriteLine("HTML Button render");
        }
    }


    public abstract class Dialog
    {
        public void render()
        {
            Button okButton = createButton();
            okButton.onClick();
            okButton.render();

        }

        public virtual Button createButton()
        {
            throw new NotImplementedException();
        }
        
    }

    public class WindowsDialog : Dialog
    {
        public override Button createButton()
        {
            return new WindowsButton();
        }
    }

    public class WebDialog : Dialog
    {
        public override Button createButton()
        {
            return new HTMLButton();
        }
    }
}
