import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { QuestionColumns, QuestionRow, QuestionService } from '../../ServerTypes/School';
import { QuestionDialog } from './QuestionDialog';

@Decorators.registerClass('ExamAppSerene.School.QuestionGrid')
export class QuestionGrid extends EntityGrid<QuestionRow, any> {
    protected getColumnsKey() { return QuestionColumns.columnsKey; }
    protected getDialogType() { return QuestionDialog; }
    protected getRowDefinition() { return QuestionRow; }
    protected getService() { return QuestionService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}