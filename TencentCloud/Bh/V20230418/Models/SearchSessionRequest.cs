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

namespace TencentCloud.Bh.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SearchSessionRequest : AbstractModel
    {
        
        /// <summary>
        /// 内部Ip
        /// </summary>
        [JsonProperty("PrivateIp")]
        public string PrivateIp{ get; set; }

        /// <summary>
        /// 外部Ip
        /// </summary>
        [JsonProperty("PublicIp")]
        public string PublicIp{ get; set; }

        /// <summary>
        /// 用户名，长度不超过20
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// 账号，长度不超过64
        /// </summary>
        [JsonProperty("Account")]
        public string Account{ get; set; }

        /// <summary>
        /// 来源Ip
        /// </summary>
        [JsonProperty("FromIp")]
        public string FromIp{ get; set; }

        /// <summary>
        /// 搜索区间的开始时间。若入参是Id，则非必传，否则为必传。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 搜索区间的结束时间
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 会话协议类型，只能是1、2、3或4 对应关系为1-tui 2-gui 3-file 4-数据库。若入参是Id，则非必传，否则为必传。
        /// </summary>
        [JsonProperty("Kind")]
        public ulong? Kind{ get; set; }

        /// <summary>
        /// 偏移量
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 分页的页内记录数，默认为20，最大200
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 姓名，长度不超过20
        /// </summary>
        [JsonProperty("RealName")]
        public string RealName{ get; set; }

        /// <summary>
        /// 主机名，长度不超过64
        /// </summary>
        [JsonProperty("DeviceName")]
        public string DeviceName{ get; set; }

        /// <summary>
        /// 状态，1为活跃，2为结束，3为强制离线，4为其他错误，5暂停会话
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 状态，1为活跃，2为结束，3为强制离线
        /// </summary>
        [JsonProperty("StatusSet")]
        public ulong?[] StatusSet{ get; set; }

        /// <summary>
        /// 若入参为Id，则其他入参字段不作为搜索依据，仅按照Id来搜索会话
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 应用资产类型, 1-web
        /// </summary>
        [JsonProperty("AppAssetKindSet")]
        public ulong?[] AppAssetKindSet{ get; set; }

        /// <summary>
        /// 应用资产Url
        /// </summary>
        [JsonProperty("AppAssetUrl")]
        public string AppAssetUrl{ get; set; }

        /// <summary>
        /// 资产类型
        /// </summary>
        [JsonProperty("DeviceKind")]
        public string DeviceKind{ get; set; }

        /// <summary>
        /// 资产类型 Linux, EKS,TKE
        /// </summary>
        [JsonProperty("DeviceKindSet")]
        public string[] DeviceKindSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PrivateIp", this.PrivateIp);
            this.SetParamSimple(map, prefix + "PublicIp", this.PublicIp);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "Account", this.Account);
            this.SetParamSimple(map, prefix + "FromIp", this.FromIp);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Kind", this.Kind);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "RealName", this.RealName);
            this.SetParamSimple(map, prefix + "DeviceName", this.DeviceName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArraySimple(map, prefix + "StatusSet.", this.StatusSet);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamArraySimple(map, prefix + "AppAssetKindSet.", this.AppAssetKindSet);
            this.SetParamSimple(map, prefix + "AppAssetUrl", this.AppAssetUrl);
            this.SetParamSimple(map, prefix + "DeviceKind", this.DeviceKind);
            this.SetParamArraySimple(map, prefix + "DeviceKindSet.", this.DeviceKindSet);
        }
    }
}

