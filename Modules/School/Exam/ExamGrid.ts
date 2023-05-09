import { Decorators, EntityGrid, QuickSearchField } from '@serenity-is/corelib';
import { ExamColumns, ExamRow, ExamService } from '../../ServerTypes/School';
import { ExamDialog } from './ExamDialog';

@Decorators.registerClass('ExamAppSerene.School.ExamGrid')
export class ExamGrid extends EntityGrid<ExamRow, any> {
    protected getColumnsKey() { return ExamColumns.columnsKey; }
    protected getDialogType() { return ExamDialog; }
    protected getRowDefinition() { return ExamRow; }
    protected getService() { return ExamService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
    protected getQuickSearchFields(): QuickSearchField[] {
        return [
            { name: "", title: "Tümü" },
            { name: "Description", title: "Açıklama" },
            
        ];
    }
}