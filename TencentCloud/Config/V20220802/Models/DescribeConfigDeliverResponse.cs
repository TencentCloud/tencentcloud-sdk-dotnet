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

namespace TencentCloud.Config.V20220802.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeConfigDeliverResponse : AbstractModel
    {
        
        /// <summary>
        /// 投递名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeliverName")]
        public string DeliverName{ get; set; }

        /// <summary>
        /// 资源六段式
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TargetArn")]
        public string TargetArn{ get; set; }

        /// <summary>
        /// 投递状态 DeliverStatus：0 关闭  1 开启
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 创建时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 日志前缀
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeliverPrefix")]
        public string DeliverPrefix{ get; set; }

        /// <summary>
        /// 投递类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeliverType")]
        public string DeliverType{ get; set; }

        /// <summary>
        /// 1：配置变更   2： 资源列表 3：全部
        /// </summary>
        [JsonProperty("DeliverContentType")]
        public ulong? DeliverContentType{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DeliverName", this.DeliverName);
            this.SetParamSimple(map, prefix + "TargetArn", this.TargetArn);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "DeliverPrefix", this.DeliverPrefix);
            this.SetParamSimple(map, prefix + "DeliverType", this.DeliverType);
            this.SetParamSimple(map, prefix + "DeliverContentType", this.DeliverContentType);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

