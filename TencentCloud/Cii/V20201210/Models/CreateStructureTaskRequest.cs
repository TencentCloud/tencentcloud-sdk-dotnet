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

namespace TencentCloud.Cii.V20201210.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateStructureTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// 保单号
        /// </summary>
        [JsonProperty("PolicyId")]
        public string PolicyId{ get; set; }

        /// <summary>
        /// 客户号
        /// </summary>
        [JsonProperty("CustomerId")]
        public string CustomerId{ get; set; }

        /// <summary>
        /// 客户姓名
        /// </summary>
        [JsonProperty("CustomerName")]
        public string CustomerName{ get; set; }

        /// <summary>
        /// 文件类型，目前只支持体检报告类型，对应的值为：HealthReport
        /// </summary>
        [JsonProperty("TaskType")]
        public string TaskType{ get; set; }

        /// <summary>
        /// 报告年份
        /// </summary>
        [JsonProperty("Year")]
        public string Year{ get; set; }

        /// <summary>
        /// 报告文件上传的地址列表，需按顺序排列。如果使用ImageList参数，置为空数组即可
        /// </summary>
        [JsonProperty("FileList")]
        public string[] FileList{ get; set; }

        /// <summary>
        /// 险种，如果是体检报告类型，此参数是必填，类型说明如下：
        /// CriticalDiseaseInsurance:重疾险
        /// LifeInsurance：寿险
        /// AccidentInsurance：意外险
        /// </summary>
        [JsonProperty("InsuranceTypes")]
        public string[] InsuranceTypes{ get; set; }

        /// <summary>
        /// 报告上传的图片内容数组，图片内容采用base64编码，需按顺序排列
        /// </summary>
        [JsonProperty("ImageList")]
        public string[] ImageList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PolicyId", this.PolicyId);
            this.SetParamSimple(map, prefix + "CustomerId", this.CustomerId);
            this.SetParamSimple(map, prefix + "CustomerName", this.CustomerName);
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamSimple(map, prefix + "Year", this.Year);
            this.SetParamArraySimple(map, prefix + "FileList.", this.FileList);
            this.SetParamArraySimple(map, prefix + "InsuranceTypes.", this.InsuranceTypes);
            this.SetParamArraySimple(map, prefix + "ImageList.", this.ImageList);
        }
    }
}

