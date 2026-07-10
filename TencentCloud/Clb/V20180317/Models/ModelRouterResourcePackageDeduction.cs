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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModelRouterResourcePackageDeduction : AbstractModel
    {
        
        /// <summary>
        /// <p>实际抵扣量</p>
        /// </summary>
        [JsonProperty("ActualDosage")]
        public string ActualDosage{ get; set; }

        /// <summary>
        /// <p>抵扣后包剩余量</p>
        /// </summary>
        [JsonProperty("AfterDeductionRemain")]
        public string AfterDeductionRemain{ get; set; }

        /// <summary>
        /// <p>抵扣前包剩余量</p>
        /// </summary>
        [JsonProperty("BeforeDeductionRemain")]
        public string BeforeDeductionRemain{ get; set; }

        /// <summary>
        /// <p>抵扣时间</p>
        /// </summary>
        [JsonProperty("DeductionTime")]
        public string DeductionTime{ get; set; }

        /// <summary>
        /// <p>原始用量</p>
        /// </summary>
        [JsonProperty("Dosage")]
        public string Dosage{ get; set; }

        /// <summary>
        /// <p>用量结束时间</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>产生用量的模型路由实例Id</p>
        /// </summary>
        [JsonProperty("ModelRouterId")]
        public string ModelRouterId{ get; set; }

        /// <summary>
        /// <p>模型路由资源包Id</p>
        /// </summary>
        [JsonProperty("ModelRouterResourcePackageId")]
        public string ModelRouterResourcePackageId{ get; set; }

        /// <summary>
        /// <p>用量开始时间</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ActualDosage", this.ActualDosage);
            this.SetParamSimple(map, prefix + "AfterDeductionRemain", this.AfterDeductionRemain);
            this.SetParamSimple(map, prefix + "BeforeDeductionRemain", this.BeforeDeductionRemain);
            this.SetParamSimple(map, prefix + "DeductionTime", this.DeductionTime);
            this.SetParamSimple(map, prefix + "Dosage", this.Dosage);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "ModelRouterId", this.ModelRouterId);
            this.SetParamSimple(map, prefix + "ModelRouterResourcePackageId", this.ModelRouterResourcePackageId);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
        }
    }
}

