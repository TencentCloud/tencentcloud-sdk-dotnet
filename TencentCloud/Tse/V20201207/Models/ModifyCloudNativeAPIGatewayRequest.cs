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

namespace TencentCloud.Tse.V20201207.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyCloudNativeAPIGatewayRequest : AbstractModel
    {
        
        /// <summary>
        /// 云原生API网关实例ID。
        /// </summary>
        [JsonProperty("GatewayId")]
        public string GatewayId{ get; set; }

        /// <summary>
        /// 云原生API网关名字, 最多支持60个字符。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 云原生API网关描述信息, 最多支持120个字符。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 是否开启 CLS 日志。暂时取值只能是 true，即只能从关闭状态变成开启状态。
        /// </summary>
        [JsonProperty("EnableCls")]
        public bool? EnableCls{ get; set; }

        /// <summary>
        /// 公网计费模式。可选取值 BANDWIDTH | TRAFFIC ，表示按带宽和按流量计费。
        /// </summary>
        [JsonProperty("InternetPayMode")]
        public string InternetPayMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GatewayId", this.GatewayId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "EnableCls", this.EnableCls);
            this.SetParamSimple(map, prefix + "InternetPayMode", this.InternetPayMode);
        }
    }
}

