/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Ocr.V20181119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InsuranceBillInfo : AbstractModel
    {
        
        /// <summary>
        /// 识别出的字段名称(关键字)，支持以下字段：
        /// 【病案首页】
        /// 姓名、性别、出生日期、出院诊断、疾病编码、入院病情等。
        /// 【费用清单】
        /// 医疗参保人员类别、身份证号、入院方式、结账日期、项目、金额等。
        /// 【结算单】
        /// 名称、单价、数量、金额、医保内、医保外等。
        /// 【医疗发票】
        /// 姓名、性别、住院时间、收费项目、金额、合计等。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 识别出的字段名称对应的值，也就是字段Name对应的字符串结果。
        /// </summary>
        [JsonProperty("Value")]
        public string Value{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Value", this.Value);
        }
    }
}

