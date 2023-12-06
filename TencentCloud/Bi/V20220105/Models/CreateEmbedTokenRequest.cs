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

namespace TencentCloud.Bi.V20220105.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateEmbedTokenRequest : AbstractModel
    {
        
        /// <summary>
        /// 分享项目id
        /// </summary>
        [JsonProperty("ProjectId")]
        public ulong? ProjectId{ get; set; }

        /// <summary>
        /// 分享页面id，嵌出看板时此为空值0
        /// </summary>
        [JsonProperty("PageId")]
        public ulong? PageId{ get; set; }

        /// <summary>
        /// page表示嵌出页面，panel表嵌出整个看板
        /// </summary>
        [JsonProperty("Scope")]
        public string Scope{ get; set; }

        /// <summary>
        /// 过期时间。 单位：分钟 最大值：240。即，4小时 默认值：240
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// 备用字段
        /// </summary>
        [JsonProperty("ExtraParam")]
        public string ExtraParam{ get; set; }

        /// <summary>
        /// 使用者企业Id(仅用于多用户)
        /// </summary>
        [JsonProperty("UserCorpId")]
        public string UserCorpId{ get; set; }

        /// <summary>
        /// 使用者Id(仅用于多用户)
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// 访问次数限制，限制范围1-99999，为空则不设置访问次数限制
        /// </summary>
        [JsonProperty("TicketNum")]
        public long? TicketNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "PageId", this.PageId);
            this.SetParamSimple(map, prefix + "Scope", this.Scope);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "ExtraParam", this.ExtraParam);
            this.SetParamSimple(map, prefix + "UserCorpId", this.UserCorpId);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "TicketNum", this.TicketNum);
        }
    }
}

