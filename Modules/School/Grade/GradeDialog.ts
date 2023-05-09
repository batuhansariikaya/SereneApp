import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { GradeForm, GradeRow, GradeService } from '../../ServerTypes/School';

@Decorators.registerClass('ExamAppSerene.School.GradeDialog')
export class GradeDialog extends EntityDialog<GradeRow, any> {
    protected getFormKey() { return GradeForm.formKey; }
    protected getRowDefinition() { return GradeRow; }
    protected getService() { return GradeService.baseUrl; }

    protected form = new GradeForm(this.idPrefix);
}