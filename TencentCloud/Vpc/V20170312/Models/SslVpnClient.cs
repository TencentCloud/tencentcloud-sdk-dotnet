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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SslVpnClient : AbstractModel
    {
        
        /// <summary>
        /// VPC实例ID。
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// SSL-VPN-SERVER 实例ID。
        /// </summary>
        [JsonProperty("SslVpnServerId")]
        public string SslVpnServerId{ get; set; }

        /// <summary>
        /// 证书状态。
        /// 0:创建中
        /// 1:正常
        /// 2:已停用
        /// 3.已过期
        /// 4.创建出错
        /// </summary>
        [JsonProperty("CertStatus")]
        public ulong? CertStatus{ get; set; }

        /// <summary>
        /// SSL-VPN-CLIENT 实例ID。
        /// </summary>
        [JsonProperty("SslVpnClientId")]
        public string SslVpnClientId{ get; set; }

        /// <summary>
        /// 证书开始时间。
        /// </summary>
        [JsonProperty("CertBeginTime")]
        public string CertBeginTime{ get; set; }

        /// <summary>
        /// 证书到期时间。
        /// </summary>
        [JsonProperty("CertEndTime")]
        public string CertEndTime{ get; set; }

        /// <summary>
        /// CLIENT NAME。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 创建CLIENT 状态。
        /// 0 创建中
        /// 1 创建出错
        /// 2 更新中
        /// 3 更新出错
        /// 4 销毁中
        /// 5 销毁出错
        /// 6 已连通
        /// 7 未知
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SslVpnServerId", this.SslVpnServerId);
            this.SetParamSimple(map, prefix + "CertStatus", this.CertStatus);
            this.SetParamSimple(map, prefix + "SslVpnClientId", this.SslVpnClientId);
            this.SetParamSimple(map, prefix + "CertBeginTime", this.CertBeginTime);
            this.SetParamSimple(map, prefix + "CertEndTime", this.CertEndTime);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "State", this.State);
        }
    }
}

