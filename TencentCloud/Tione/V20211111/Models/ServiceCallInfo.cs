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

namespace TencentCloud.Tione.V20211111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ServiceCallInfo : AbstractModel
    {
        
        /// <summary>
        /// 服务组id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ServiceGroupId")]
        public string ServiceGroupId{ get; set; }

        /// <summary>
        /// 内网http调用地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InnerHttpAddr")]
        public string InnerHttpAddr{ get; set; }

        /// <summary>
        /// 内网https调用地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InnerHttpsAddr")]
        public string InnerHttpsAddr{ get; set; }

        /// <summary>
        /// 内网http调用地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OuterHttpAddr")]
        public string OuterHttpAddr{ get; set; }

        /// <summary>
        /// 内网https调用地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OuterHttpsAddr")]
        public string OuterHttpsAddr{ get; set; }

        /// <summary>
        /// 调用key
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AppKey")]
        public string AppKey{ get; set; }

        /// <summary>
        /// 调用secret
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AppSecret")]
        public string AppSecret{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ServiceGroupId", this.ServiceGroupId);
            this.SetParamSimple(map, prefix + "InnerHttpAddr", this.InnerHttpAddr);
            this.SetParamSimple(map, prefix + "InnerHttpsAddr", this.InnerHttpsAddr);
            this.SetParamSimple(map, prefix + "OuterHttpAddr", this.OuterHttpAddr);
            this.SetParamSimple(map, prefix + "OuterHttpsAddr", this.OuterHttpsAddr);
            this.SetParamSimple(map, prefix + "AppKey", this.AppKey);
            this.SetParamSimple(map, prefix + "AppSecret", this.AppSecret);
        }
    }
}

