import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { QuestionForm, QuestionRow, QuestionService } from '../../ServerTypes/School';

@Decorators.registerClass('ExamAppSerene.School.QuestionDialog')
export class QuestionDialog extends EntityDialog<QuestionRow, any> {
    protected getFormKey() { return QuestionForm.formKey; }
    protected getRowDefinition() { return QuestionRow; }
    protected getService() { return QuestionService.baseUrl; }

    protected form = new QuestionForm(this.idPrefix);
}