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

namespace TencentCloud.Apm.V20210622.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateApmSampleConfigRequest : AbstractModel
    {
        
        /// <summary>
        /// 业务系统ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 采样率
        /// </summary>
        [JsonProperty("SampleRate")]
        public long? SampleRate{ get; set; }

        /// <summary>
        /// 应用名
        /// </summary>
        [JsonProperty("ServiceName")]
        public string ServiceName{ get; set; }

        /// <summary>
        /// 采样规则名
        /// </summary>
        [JsonProperty("SampleName")]
        public string SampleName{ get; set; }

        /// <summary>
        /// 采样Tags
        /// </summary>
        [JsonProperty("Tags")]
        public APMKVItem[] Tags{ get; set; }

        /// <summary>
        /// 接口名
        /// </summary>
        [JsonProperty("OperationName")]
        public string OperationName{ get; set; }

        /// <summary>
        /// 0=精确匹配（默认）；1=前缀匹配；2=后缀匹配
        /// </summary>
        [JsonProperty("OperationType")]
        public long? OperationType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "SampleRate", this.SampleRate);
            this.SetParamSimple(map, prefix + "ServiceName", this.ServiceName);
            this.SetParamSimple(map, prefix + "SampleName", this.SampleName);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "OperationName", this.OperationName);
            this.SetParamSimple(map, prefix + "OperationType", this.OperationType);
        }
    }
}

