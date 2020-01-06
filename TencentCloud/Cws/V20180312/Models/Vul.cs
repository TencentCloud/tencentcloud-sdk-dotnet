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

namespace TencentCloud.Cws.V20180312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Vul : AbstractModel
    {
        
        /// <summary>
        /// 漏洞ID。
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// 站点ID。
        /// </summary>
        [JsonProperty("SiteId")]
        public ulong? SiteId{ get; set; }

        /// <summary>
        /// 扫描引擎的扫描任务ID。
        /// </summary>
        [JsonProperty("TaskId")]
        public ulong? TaskId{ get; set; }

        /// <summary>
        /// 漏洞级别：high、middle、low、notice。
        /// </summary>
        [JsonProperty("Level")]
        public string Level{ get; set; }

        /// <summary>
        /// 漏洞名称。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 出现漏洞的url。
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// 网址/细节。
        /// </summary>
        [JsonProperty("Html")]
        public string Html{ get; set; }

        /// <summary>
        /// 漏洞类型。
        /// </summary>
        [JsonProperty("Nickname")]
        public string Nickname{ get; set; }

        /// <summary>
        /// 危害说明。
        /// </summary>
        [JsonProperty("Harm")]
        public string Harm{ get; set; }

        /// <summary>
        /// 漏洞描述。
        /// </summary>
        [JsonProperty("Describe")]
        public string Describe{ get; set; }

        /// <summary>
        /// 解决方案。
        /// </summary>
        [JsonProperty("Solution")]
        public string Solution{ get; set; }

        /// <summary>
        /// 漏洞参考。
        /// </summary>
        [JsonProperty("From")]
        public string From{ get; set; }

        /// <summary>
        /// 漏洞通过该参数攻击。
        /// </summary>
        [JsonProperty("Parameter")]
        public string Parameter{ get; set; }

        /// <summary>
        /// CreatedAt。
        /// </summary>
        [JsonProperty("CreatedAt")]
        public string CreatedAt{ get; set; }

        /// <summary>
        /// UpdatedAt。
        /// </summary>
        [JsonProperty("UpdatedAt")]
        public string UpdatedAt{ get; set; }

        /// <summary>
        /// 是否已经添加误报，0-否，1-是。
        /// </summary>
        [JsonProperty("IsReported")]
        public ulong? IsReported{ get; set; }

        /// <summary>
        /// 云用户appid。
        /// </summary>
        [JsonProperty("Appid")]
        public ulong? Appid{ get; set; }

        /// <summary>
        /// 云用户标识。
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "SiteId", this.SiteId);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "Html", this.Html);
            this.SetParamSimple(map, prefix + "Nickname", this.Nickname);
            this.SetParamSimple(map, prefix + "Harm", this.Harm);
            this.SetParamSimple(map, prefix + "Describe", this.Describe);
            this.SetParamSimple(map, prefix + "Solution", this.Solution);
            this.SetParamSimple(map, prefix + "From", this.From);
            this.SetParamSimple(map, prefix + "Parameter", this.Parameter);
            this.SetParamSimple(map, prefix + "CreatedAt", this.CreatedAt);
            this.SetParamSimple(map, prefix + "UpdatedAt", this.UpdatedAt);
            this.SetParamSimple(map, prefix + "IsReported", this.IsReported);
            this.SetParamSimple(map, prefix + "Appid", this.Appid);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
        }
    }
}

