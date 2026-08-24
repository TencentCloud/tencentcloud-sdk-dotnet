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

    public class DspmAuditSessionInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>审计日志数</p>
        /// </summary>
        [JsonProperty("SqlCount")]
        public long? SqlCount{ get; set; }

        /// <summary>
        /// <p>登出时间</p>
        /// </summary>
        [JsonProperty("LogoutTime")]
        public long? LogoutTime{ get; set; }

        /// <summary>
        /// <p>客户端 IP</p>
        /// </summary>
        [JsonProperty("ClientIp")]
        public string ClientIp{ get; set; }

        /// <summary>
        /// <p>客户端端口</p>
        /// </summary>
        [JsonProperty("ClientPort")]
        public long? ClientPort{ get; set; }

        /// <summary>
        /// <p>数据库 IP</p>
        /// </summary>
        [JsonProperty("DbIp")]
        public string DbIp{ get; set; }

        /// <summary>
        /// <p>数据库名称</p>
        /// </summary>
        [JsonProperty("DbName")]
        public string DbName{ get; set; }

        /// <summary>
        /// <p>数据库端口</p>
        /// </summary>
        [JsonProperty("DbPort")]
        public long? DbPort{ get; set; }

        /// <summary>
        /// <p>数据库用户</p>
        /// </summary>
        [JsonProperty("DbUser")]
        public string DbUser{ get; set; }

        /// <summary>
        /// <p>审计单元 ID</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public long? InstanceId{ get; set; }

        /// <summary>
        /// <p>操作时间(时间)</p>
        /// </summary>
        [JsonProperty("OpTime")]
        public long? OpTime{ get; set; }

        /// <summary>
        /// <p>返回码</p>
        /// </summary>
        [JsonProperty("RetNo")]
        public long? RetNo{ get; set; }

        /// <summary>
        /// <p>会话Id</p>
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// <p>登录时间</p>
        /// </summary>
        [JsonProperty("LoginTime")]
        public long? LoginTime{ get; set; }

        /// <summary>
        /// <p>数据资产名称</p>
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// <p>数据资产名称</p>
        /// </summary>
        [JsonProperty("AssetName")]
        public string AssetName{ get; set; }

        /// <summary>
        /// <p>流量来源</p>
        /// </summary>
        [JsonProperty("SourceType")]
        public string SourceType{ get; set; }

        /// <summary>
        /// <p>流量来源英文</p>
        /// </summary>
        [JsonProperty("SourceTypeEn")]
        public string SourceTypeEn{ get; set; }

        /// <summary>
        /// <p>资产所属账号app id</p>
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// <p>流量来源</p>
        /// </summary>
        [JsonProperty("SourceTypeEnDisplayName")]
        public string SourceTypeEnDisplayName{ get; set; }

        /// <summary>
        /// <p>昵称</p>
        /// </summary>
        [JsonProperty("NickName")]
        public string NickName{ get; set; }

        /// <summary>
        /// <p>用户ID</p>
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// <p>数据库类型</p><p>枚举值：</p><ul><li>MongoDB： mongodb</li></ul>
        /// </summary>
        [JsonProperty("DbType")]
        public string DbType{ get; set; }

        /// <summary>
        /// <p>资产类型</p><p>枚举值：</p><ul><li>cdb： mysql</li><li>mongodb： mongodb</li></ul>
        /// </summary>
        [JsonProperty("AssetType")]
        public string AssetType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SqlCount", this.SqlCount);
            this.SetParamSimple(map, prefix + "LogoutTime", this.LogoutTime);
            this.SetParamSimple(map, prefix + "ClientIp", this.ClientIp);
            this.SetParamSimple(map, prefix + "ClientPort", this.ClientPort);
            this.SetParamSimple(map, prefix + "DbIp", this.DbIp);
            this.SetParamSimple(map, prefix + "DbName", this.DbName);
            this.SetParamSimple(map, prefix + "DbPort", this.DbPort);
            this.SetParamSimple(map, prefix + "DbUser", this.DbUser);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "OpTime", this.OpTime);
            this.SetParamSimple(map, prefix + "RetNo", this.RetNo);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "LoginTime", this.LoginTime);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "AssetName", this.AssetName);
            this.SetParamSimple(map, prefix + "SourceType", this.SourceType);
            this.SetParamSimple(map, prefix + "SourceTypeEn", this.SourceTypeEn);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "SourceTypeEnDisplayName", this.SourceTypeEnDisplayName);
            this.SetParamSimple(map, prefix + "NickName", this.NickName);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "DbType", this.DbType);
            this.SetParamSimple(map, prefix + "AssetType", this.AssetType);
        }
    }
}

