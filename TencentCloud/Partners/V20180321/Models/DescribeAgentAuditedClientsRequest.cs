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

    public class DescribeAgentAuditedClientsRequest : AbstractModel
    {
        
        /// <summary>
        /// 客户账号ID
        /// </summary>
        [JsonProperty("ClientUin")]
        public string ClientUin{ get; set; }

        /// <summary>
        /// 客户名称。由于涉及隐私，名称打码显示，故名称仅支持打码后的模糊搜索
        /// </summary>
        [JsonProperty("ClientName")]
        public string ClientName{ get; set; }

        /// <summary>
        /// 客户类型，a/b，类型定义参考代理商相关政策文档
        /// </summary>
        [JsonProperty("ClientFlag")]
        public string ClientFlag{ get; set; }

        /// <summary>
        /// ASC/DESC， 不区分大小写，按审核通过时间排序
        /// </summary>
        [JsonProperty("OrderDirection")]
        public string OrderDirection{ get; set; }

        /// <summary>
        /// 客户账号ID列表
        /// </summary>
        [JsonProperty("ClientUins")]
        public string[] ClientUins{ get; set; }

        /// <summary>
        /// 是否欠费。0：不欠费；1：欠费
        /// </summary>
        [JsonProperty("HasOverdueBill")]
        public ulong? HasOverdueBill{ get; set; }

        /// <summary>
        /// 客户备注
        /// </summary>
        [JsonProperty("ClientRemark")]
        public string ClientRemark{ get; set; }

        /// <summary>
        /// 偏移量
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 限制数目
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

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
        /// </summary>
        [JsonProperty("SalesUin")]
        public string SalesUin{ get; set; }

        /// <summary>
        /// 业务员姓名（模糊查询）
        /// </summary>
        [JsonProperty("SalesName")]
        public string SalesName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClientUin", this.ClientUin);
            this.SetParamSimple(map, prefix + "ClientName", this.ClientName);
            this.SetParamSimple(map, prefix + "ClientFlag", this.ClientFlag);
            this.SetParamSimple(map, prefix + "OrderDirection", this.OrderDirection);
            this.SetParamArraySimple(map, prefix + "ClientUins.", this.ClientUins);
            this.SetParamSimple(map, prefix + "HasOverdueBill", this.HasOverdueBill);
            this.SetParamSimple(map, prefix + "ClientRemark", this.ClientRemark);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "ClientType", this.ClientType);
            this.SetParamSimple(map, prefix + "ProjectType", this.ProjectType);
            this.SetParamSimple(map, prefix + "SalesUin", this.SalesUin);
            this.SetParamSimple(map, prefix + "SalesName", this.SalesName);
        }
    }
}

