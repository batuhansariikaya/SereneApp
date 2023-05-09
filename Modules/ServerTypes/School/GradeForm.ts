import { StringEditor, IntegerEditor, BooleanEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface GradeForm {
    Code: StringEditor;
    Name: StringEditor;
    Capacity: IntegerEditor;
    Status: BooleanEditor;
}

export class GradeForm extends PrefixedContext {
    static formKey = 'School.Grade';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!GradeForm.init)  {
            GradeForm.init = true;

            var w0 = StringEditor;
            var w1 = IntegerEditor;
            var w2 = BooleanEditor;

            initFormType(GradeForm, [
                'Code', w0,
                'Name', w0,
                'Capacity', w1,
                'Status', w2
            ]);
        }
    }
}