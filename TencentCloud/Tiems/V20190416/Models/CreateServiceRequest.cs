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

namespace TencentCloud.Tiems.V20190416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateServiceRequest : AbstractModel
    {
        
        /// <summary>
        /// 扩缩容配置
        /// </summary>
        [JsonProperty("Scaler")]
        public Scaler Scaler{ get; set; }

        /// <summary>
        /// 服务配置Id
        /// </summary>
        [JsonProperty("ServiceConfigId")]
        public long? ServiceConfigId{ get; set; }

        /// <summary>
        /// 服务名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 扩缩容方式，支持AUTO, MANUAL，分别表示自动扩缩容和手动扩缩容
        /// </summary>
        [JsonProperty("ScaleMode")]
        public string ScaleMode{ get; set; }

        /// <summary>
        /// 集群，不填则使用默认集群。
        /// </summary>
        [JsonProperty("Cluster")]
        public string Cluster{ get; set; }


        /// <summary>
        /// 内部实现，用户禁止调用
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Scaler.", this.Scaler);
            this.SetParamSimple(map, prefix + "ServiceConfigId", this.ServiceConfigId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "ScaleMode", this.ScaleMode);
            this.SetParamSimple(map, prefix + "Cluster", this.Cluster);
        }
    }
}

