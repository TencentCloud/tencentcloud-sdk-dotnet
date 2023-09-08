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

namespace TencentCloud.Trocket.V20230308.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 实例名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 消息发送和接收的比例
        /// </summary>
        [JsonProperty("SendReceiveRatio")]
        public float? SendReceiveRatio{ get; set; }

        /// <summary>
        /// 调整实例规格的商品代号
        /// </summary>
        [JsonProperty("SkuCode")]
        public string SkuCode{ get; set; }

        /// <summary>
        /// 消息保留时长，小时为单位
        /// </summary>
        [JsonProperty("MessageRetention")]
        public long? MessageRetention{ get; set; }

        /// <summary>
        /// 是否开启弹性TPS
        /// </summary>
        [JsonProperty("ScaledTpsEnabled")]
        public bool? ScaledTpsEnabled{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "SendReceiveRatio", this.SendReceiveRatio);
            this.SetParamSimple(map, prefix + "SkuCode", this.SkuCode);
            this.SetParamSimple(map, prefix + "MessageRetention", this.MessageRetention);
            this.SetParamSimple(map, prefix + "ScaledTpsEnabled", this.ScaledTpsEnabled);
        }
    }
}

