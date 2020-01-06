/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Dts.V20180330.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SyncStepDetailInfo : AbstractModel
    {
        
        /// <summary>
        /// 步骤编号
        /// </summary>
        [JsonProperty("StepNo")]
        public ulong? StepNo{ get; set; }

        /// <summary>
        /// 步骤名
        /// </summary>
        [JsonProperty("StepName")]
        public string StepName{ get; set; }

        /// <summary>
        /// 能否中止
        /// </summary>
        [JsonProperty("CanStop")]
        public long? CanStop{ get; set; }

        /// <summary>
        /// 步骤号
        /// </summary>
        [JsonProperty("StepId")]
        public long? StepId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StepNo", this.StepNo);
            this.SetParamSimple(map, prefix + "StepName", this.StepName);
            this.SetParamSimple(map, prefix + "CanStop", this.CanStop);
            this.SetParamSimple(map, prefix + "StepId", this.StepId);
        }
    }
}

