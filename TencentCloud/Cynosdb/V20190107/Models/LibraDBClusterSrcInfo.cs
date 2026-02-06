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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LibraDBClusterSrcInfo : AbstractModel
    {
        
        /// <summary>
        /// 源端类型
        /// </summary>
        [JsonProperty("SrcInstanceType")]
        public string SrcInstanceType{ get; set; }

        /// <summary>
        /// 网络类型
        /// </summary>
        [JsonProperty("AccessType")]
        public string AccessType{ get; set; }

        /// <summary>
        /// 源端实例ID
        /// </summary>
        [JsonProperty("SrcInstanceId")]
        public string SrcInstanceId{ get; set; }

        /// <summary>
        /// 源端集群ID
        /// </summary>
        [JsonProperty("SrcClusterId")]
        public string SrcClusterId{ get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        [JsonProperty("IP")]
        public string IP{ get; set; }

        /// <summary>
        /// 端口
        /// </summary>
        [JsonProperty("Port")]
        public string Port{ get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [JsonProperty("User")]
        public string User{ get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// 源端sql_mode
        /// </summary>
        [JsonProperty("SqlMode")]
        public string SqlMode{ get; set; }

        /// <summary>
        /// 源端应用id
        /// </summary>
        [JsonProperty("SrcAppId")]
        public long? SrcAppId{ get; set; }

        /// <summary>
        /// 源端账号
        /// </summary>
        [JsonProperty("SrcUin")]
        public string SrcUin{ get; set; }

        /// <summary>
        /// 源端子账号
        /// </summary>
        [JsonProperty("SrcSubAccountUin")]
        public string SrcSubAccountUin{ get; set; }

        /// <summary>
        /// 账号
        /// </summary>
        [JsonProperty("AccountMode")]
        public string AccountMode{ get; set; }

        /// <summary>
        /// 源端实例地域
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 对源端实例的操作
        /// </summary>
        [JsonProperty("Operation")]
        public string Operation{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SrcInstanceType", this.SrcInstanceType);
            this.SetParamSimple(map, prefix + "AccessType", this.AccessType);
            this.SetParamSimple(map, prefix + "SrcInstanceId", this.SrcInstanceId);
            this.SetParamSimple(map, prefix + "SrcClusterId", this.SrcClusterId);
            this.SetParamSimple(map, prefix + "IP", this.IP);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "User", this.User);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamSimple(map, prefix + "SqlMode", this.SqlMode);
            this.SetParamSimple(map, prefix + "SrcAppId", this.SrcAppId);
            this.SetParamSimple(map, prefix + "SrcUin", this.SrcUin);
            this.SetParamSimple(map, prefix + "SrcSubAccountUin", this.SrcSubAccountUin);
            this.SetParamSimple(map, prefix + "AccountMode", this.AccountMode);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Operation", this.Operation);
        }
    }
}

