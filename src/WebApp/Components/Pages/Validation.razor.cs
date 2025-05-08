using FluentValidation;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace WebApp.Components.Pages;

public partial class Validation : ComponentBase
{
    public string Text { get; set; }

    private async Task Submit(MouseEventArgs arg)
    {
        var validationResultL1 = await new ValidationL1().ValidateAsync(new Data(Text));
        var validationResultL2 = await new ValidationL2().ValidateAsync(new Data(Text));
        var validationResultL3 = await new ValidationL3().ValidateAsync(new Data(Text));
    }
}

public record Data(string Text);

public class ValidationL1 : AbstractValidator<Data>
{
    public ValidationL1()
    {
        RuleFor(x => x.Text)
            .NotEmpty().WithMessage("Text is required [L1]");
    }
}
public class ValidationL2 : AbstractValidator<Data>
{
    public ValidationL2()
    {
        RuleFor(x => x.Text)
            .NotEmpty().WithMessage("Text is required [L2]");
    }
}
public class ValidationL3 : AbstractValidator<Data>
{
    public ValidationL3()
    {
        RuleFor(x => x.Text)
            .NotEmpty().WithMessage("Text is required [L3]");
    }
}