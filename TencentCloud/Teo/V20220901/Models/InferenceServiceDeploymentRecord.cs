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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InferenceServiceDeploymentRecord : AbstractModel
    {
        
        /// <summary>
        /// 部署记录 ID。
        /// </summary>
        [JsonProperty("RecordId")]
        public string RecordId{ get; set; }

        /// <summary>
        /// 部署操作类型，取值：
        /// <li>create：创建；</li>
        /// <li>update：更新；</li>
        /// <li>resume：启用；</li>
        /// <li>stop：停用。</li>
        /// </summary>
        [JsonProperty("Operation")]
        public string Operation{ get; set; }

        /// <summary>
        /// 部署状态，取值：
        /// <li>processing：部署中；</li>
        /// <li>succeeded：部署成功；</li>
        /// <li>failed：部署失败。</li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 部署时长，单位：秒。
        /// </summary>
        [JsonProperty("Duration")]
        public long? Duration{ get; set; }

        /// <summary>
        /// 本次推理服务部署的配置。
        /// </summary>
        [JsonProperty("InferenceServiceConfig")]
        public InferenceServiceConfig InferenceServiceConfig{ get; set; }

        /// <summary>
        /// 部署发起时间，使用 [ISO 日期格式](https://cloud.tencent.com/document/product/266/11732#I)。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 该部署配置是否是当前生效配置，取值：
        /// <li> active：当前生效配置；</li>
        /// <li> inactive：历史版本或异常版本配置。</li>
        /// </summary>
        [JsonProperty("ActiveStatus")]
        public string ActiveStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RecordId", this.RecordId);
            this.SetParamSimple(map, prefix + "Operation", this.Operation);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamObj(map, prefix + "InferenceServiceConfig.", this.InferenceServiceConfig);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ActiveStatus", this.ActiveStatus);
        }
    }
}

