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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDspmSessionListRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>集团账号的成员id</p>
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }

        /// <summary>
        /// <p>限制数目</p>
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// <p>偏移量</p>
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// <p>登陆状态(0 全部 1 成功 2 失败)</p>
        /// </summary>
        [JsonProperty("LoginType")]
        public long? LoginType{ get; set; }

        /// <summary>
        /// <p>数据库端口</p>
        /// </summary>
        [JsonProperty("DbName")]
        public string DbName{ get; set; }

        /// <summary>
        /// <p>数据库名称</p>
        /// </summary>
        [JsonProperty("DbPort")]
        public long? DbPort{ get; set; }

        /// <summary>
        /// <p>数据库 IP</p>
        /// </summary>
        [JsonProperty("DbIp")]
        public string DbIp{ get; set; }

        /// <summary>
        /// <p>资产 ID</p>
        /// </summary>
        [JsonProperty("AssetsId")]
        public long? AssetsId{ get; set; }

        /// <summary>
        /// <p>会话 ID</p>
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// <p>客户端 IP</p>
        /// </summary>
        [JsonProperty("ClientSideIp")]
        public string ClientSideIp{ get; set; }

        /// <summary>
        /// <p>用户名</p>
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// <p>结束时间</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public long? EndTime{ get; set; }

        /// <summary>
        /// <p>开始时间</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public long? StartTime{ get; set; }

        /// <summary>
        /// <p>流量来源  取值 Agent/Proxy/空；传Agent会返回Agent的日志，传Proxy会返回Proxy日志，两者都传或不传则返回所有</p>
        /// </summary>
        [JsonProperty("SourceTypes")]
        public string[] SourceTypes{ get; set; }

        /// <summary>
        /// <p>[&quot;MySQL&quot;]</p>
        /// </summary>
        [JsonProperty("DbTypes")]
        public string[] DbTypes{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "LoginType", this.LoginType);
            this.SetParamSimple(map, prefix + "DbName", this.DbName);
            this.SetParamSimple(map, prefix + "DbPort", this.DbPort);
            this.SetParamSimple(map, prefix + "DbIp", this.DbIp);
            this.SetParamSimple(map, prefix + "AssetsId", this.AssetsId);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "ClientSideIp", this.ClientSideIp);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamArraySimple(map, prefix + "SourceTypes.", this.SourceTypes);
            this.SetParamArraySimple(map, prefix + "DbTypes.", this.DbTypes);
        }
    }
}

