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

namespace TencentCloud.Ess.V20201111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateDraftContractByPromptsTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>执行本接口操作的员工信息。 注: 在调用此接口时，请确保指定的员工已获得所需的接口调用权限，并具备接口传入的相应资源的数据权限。</p>
        /// </summary>
        [JsonProperty("Operator")]
        public UserInfo Operator{ get; set; }

        /// <summary>
        /// <p>起草要求，范围要求 5-1000 字</p>
        /// </summary>
        [JsonProperty("Requirement")]
        public string Requirement{ get; set; }

        /// <summary>
        /// <p>参考模板文件资源id（PDF/Word格式），大小不超过1M，通过<a href="https://qian.tencent.com/developers/companyApis/templatesAndFiles/UploadFiles">上传文件</a>接口来获取。</p>
        /// </summary>
        [JsonProperty("ReferenceTemplateId")]
        public string ReferenceTemplateId{ get; set; }

        /// <summary>
        /// <p>相关规定文件资源id列表（PDF/Word格式），最多3个文件，每个大小不超过1M，通过<a href="https://qian.tencent.com/developers/companyApis/templatesAndFiles/UploadFiles">上传文件</a>接口来获取。</p>
        /// </summary>
        [JsonProperty("RequirementFileIds")]
        public string[] RequirementFileIds{ get; set; }

        /// <summary>
        /// <p>起草合同的语言要求（zh，en）默认zh</p>
        /// </summary>
        [JsonProperty("ContractLanguage")]
        public string ContractLanguage{ get; set; }

        /// <summary>
        /// <p>审查任务id，仅支持传入1个，通过<a href="https://qian.tencent.com/developers/companyApis/%E5%90%88%E5%90%8C%E6%99%BA%E8%83%BD%E7%9B%B8%E5%85%B3%E6%8E%A5%E5%8F%A3/CreateBatchContractReviewTask/">批量创建合同审查任务</a>接口来获取。</p>
        /// </summary>
        [JsonProperty("ReviewTaskId")]
        public string ReviewTaskId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
            this.SetParamSimple(map, prefix + "Requirement", this.Requirement);
            this.SetParamSimple(map, prefix + "ReferenceTemplateId", this.ReferenceTemplateId);
            this.SetParamArraySimple(map, prefix + "RequirementFileIds.", this.RequirementFileIds);
            this.SetParamSimple(map, prefix + "ContractLanguage", this.ContractLanguage);
            this.SetParamSimple(map, prefix + "ReviewTaskId", this.ReviewTaskId);
        }
    }
}

