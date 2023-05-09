import { StringEditor, IntegerEditor, BooleanEditor, DateEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface ExamForm {
    Name: StringEditor;
    Description: StringEditor;
    Time: IntegerEditor;
    Status: BooleanEditor;
    CreatedDate: DateEditor;
}

export class ExamForm extends PrefixedContext {
    static formKey = 'School.Exam';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ExamForm.init)  {
            ExamForm.init = true;

            var w0 = StringEditor;
            var w1 = IntegerEditor;
            var w2 = BooleanEditor;
            var w3 = DateEditor;

            initFormType(ExamForm, [
                'Name', w0,
                'Description', w0,
                'Time', w1,
                'Status', w2,
                'CreatedDate', w3
            ]);
        }
    }
}