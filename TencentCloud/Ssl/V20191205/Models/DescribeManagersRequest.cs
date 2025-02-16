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

namespace TencentCloud.Ssl.V20191205.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeManagersRequest : AbstractModel
    {
        
        /// <summary>
        /// 公司ID,可以从DescribeCompanies接口获取
        /// </summary>
        [JsonProperty("CompanyId")]
        public long? CompanyId{ get; set; }

        /// <summary>
        /// 分页偏移量，如果不传默认值为0
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 分页每页数量，如果不传默认值为10，最大值为1000
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 管理人姓名（将废弃），请使用SearchKey
        /// </summary>
        [JsonProperty("ManagerName")]
        public string ManagerName{ get; set; }

        /// <summary>
        /// 模糊查询管理人邮箱（将废弃），请使用SearchKey
        /// </summary>
        [JsonProperty("ManagerMail")]
        public string ManagerMail{ get; set; }

        /// <summary>
        /// 根据管理人状态进行筛选，取值有
        /// 'none' 未提交审核
        /// 'audit', 亚信审核中
        /// 'CAaudit' CA审核中
        /// 'ok' 已审核
        /// 'invalid'  审核失败
        /// 'expiring'  即将过期
        /// 'expired' 已过期
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 根据这样的格式:管理人姓|管理人名|邮箱|部门 ,进行精准匹配
        /// </summary>
        [JsonProperty("SearchKey")]
        public string SearchKey{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CompanyId", this.CompanyId);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "ManagerName", this.ManagerName);
            this.SetParamSimple(map, prefix + "ManagerMail", this.ManagerMail);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "SearchKey", this.SearchKey);
        }
    }
}

