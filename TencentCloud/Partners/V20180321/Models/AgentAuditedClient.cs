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

namespace TencentCloud.Partners.V20180321.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AgentAuditedClient : AbstractModel
    {
        
        /// <summary>
        /// 代理商账号ID
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// 代客账号ID
        /// </summary>
        [JsonProperty("ClientUin")]
        public string ClientUin{ get; set; }

        /// <summary>
        /// 代客审核通过时间戳
        /// </summary>
        [JsonProperty("AgentTime")]
        public string AgentTime{ get; set; }

        /// <summary>
        /// 代客类型，可能值为a/b/c
        /// </summary>
        [JsonProperty("ClientFlag")]
        public string ClientFlag{ get; set; }

        /// <summary>
        /// 代客备注
        /// </summary>
        [JsonProperty("ClientRemark")]
        public string ClientRemark{ get; set; }

        /// <summary>
        /// 代客名称（首选实名认证名称）
        /// </summary>
        [JsonProperty("ClientName")]
        public string ClientName{ get; set; }

        /// <summary>
        /// 认证类型, 0：个人，1：企业；其他：未认证
        /// </summary>
        [JsonProperty("AuthType")]
        public string AuthType{ get; set; }

        /// <summary>
        /// 代客APPID
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// 上月消费金额
        /// </summary>
        [JsonProperty("LastMonthAmt")]
        public long? LastMonthAmt{ get; set; }

        /// <summary>
        /// 本月消费金额
        /// </summary>
        [JsonProperty("ThisMonthAmt")]
        public long? ThisMonthAmt{ get; set; }

        /// <summary>
        /// 是否欠费,0：不欠费；1：欠费
        /// </summary>
        [JsonProperty("HasOverdueBill")]
        public ulong? HasOverdueBill{ get; set; }

        /// <summary>
        /// 客户类型：可以为new(新拓)/assign(指定)/old(存量)/空
        /// </summary>
        [JsonProperty("ClientType")]
        public string ClientType{ get; set; }

        /// <summary>
        /// 项目类型：可以为self(自拓项目)/platform(合作项目)/repeat(复算项目  )/空
        /// </summary>
        [JsonProperty("ProjectType")]
        public string ProjectType{ get; set; }

        /// <summary>
        /// 业务员ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SalesUin")]
        public string SalesUin{ get; set; }

        /// <summary>
        /// 业务员姓名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SalesName")]
        public string SalesName{ get; set; }

        /// <summary>
        /// 代客邮箱
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Mail")]
        public string Mail{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "ClientUin", this.ClientUin);
            this.SetParamSimple(map, prefix + "AgentTime", this.AgentTime);
            this.SetParamSimple(map, prefix + "ClientFlag", this.ClientFlag);
            this.SetParamSimple(map, prefix + "ClientRemark", this.ClientRemark);
            this.SetParamSimple(map, prefix + "ClientName", this.ClientName);
            this.SetParamSimple(map, prefix + "AuthType", this.AuthType);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "LastMonthAmt", this.LastMonthAmt);
            this.SetParamSimple(map, prefix + "ThisMonthAmt", this.ThisMonthAmt);
            this.SetParamSimple(map, prefix + "HasOverdueBill", this.HasOverdueBill);
            this.SetParamSimple(map, prefix + "ClientType", this.ClientType);
            this.SetParamSimple(map, prefix + "ProjectType", this.ProjectType);
            this.SetParamSimple(map, prefix + "SalesUin", this.SalesUin);
            this.SetParamSimple(map, prefix + "SalesName", this.SalesName);
            this.SetParamSimple(map, prefix + "Mail", this.Mail);
        }
    }
}

