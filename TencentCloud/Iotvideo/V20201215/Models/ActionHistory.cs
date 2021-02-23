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

namespace TencentCloud.Iotvideo.V20201215.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ActionHistory : AbstractModel
    {
        
        /// <summary>
        /// 设备名称
        /// </summary>
        [JsonProperty("DeviceName")]
        public string DeviceName{ get; set; }

        /// <summary>
        /// 动作Id
        /// </summary>
        [JsonProperty("ActionId")]
        public string ActionId{ get; set; }

        /// <summary>
        /// 动作名称
        /// </summary>
        [JsonProperty("ActionName")]
        public string ActionName{ get; set; }

        /// <summary>
        /// 请求时间
        /// </summary>
        [JsonProperty("ReqTime")]
        public ulong? ReqTime{ get; set; }

        /// <summary>
        /// 响应时间
        /// </summary>
        [JsonProperty("RspTime")]
        public ulong? RspTime{ get; set; }

        /// <summary>
        /// 输入参数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InputParams")]
        public string InputParams{ get; set; }

        /// <summary>
        /// 输出参数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OutputParams")]
        public string OutputParams{ get; set; }

        /// <summary>
        /// 调用方式
        /// </summary>
        [JsonProperty("Calling")]
        public string Calling{ get; set; }

        /// <summary>
        /// 调用Id
        /// </summary>
        [JsonProperty("ClientToken")]
        public string ClientToken{ get; set; }

        /// <summary>
        /// 调用状态
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DeviceName", this.DeviceName);
            this.SetParamSimple(map, prefix + "ActionId", this.ActionId);
            this.SetParamSimple(map, prefix + "ActionName", this.ActionName);
            this.SetParamSimple(map, prefix + "ReqTime", this.ReqTime);
            this.SetParamSimple(map, prefix + "RspTime", this.RspTime);
            this.SetParamSimple(map, prefix + "InputParams", this.InputParams);
            this.SetParamSimple(map, prefix + "OutputParams", this.OutputParams);
            this.SetParamSimple(map, prefix + "Calling", this.Calling);
            this.SetParamSimple(map, prefix + "ClientToken", this.ClientToken);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

