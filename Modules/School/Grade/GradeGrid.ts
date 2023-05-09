import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { GradeColumns, GradeRow, GradeService } from '../../ServerTypes/School';
import { GradeDialog } from './GradeDialog';

@Decorators.registerClass('ExamAppSerene.School.GradeGrid')
export class GradeGrid extends EntityGrid<GradeRow, any> {
    protected getColumnsKey() { return GradeColumns.columnsKey; }
    protected getDialogType() { return GradeDialog; }
    protected getRowDefinition() { return GradeRow; }
    protected getService() { return GradeService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}