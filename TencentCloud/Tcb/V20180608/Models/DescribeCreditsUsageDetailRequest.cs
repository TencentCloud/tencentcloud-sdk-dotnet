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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCreditsUsageDetailRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>模块列表</p><p>枚举值：</p><ul><li>FLEXDB： 文档数据库</li><li>TDSQL： MYSQL数据库</li><li>SCF： 云函数</li><li>AI： 大模型</li><li>EKS： 云托管</li><li>COS： 云存储</li><li>HOSTING： 静态托管</li><li>Auth： 用户权限</li><li>APIInvocation： API调用</li><li>HTTPInvocation： HTTP调用</li><li>VM： 主机</li><li>Workflow： 工作流</li><li>Other： 其他</li><li>PostgreSQL： PostgreSQL</li><li>Token： Token</li></ul>
        /// </summary>
        [JsonProperty("Modules")]
        public string[] Modules{ get; set; }

        /// <summary>
        /// <p>开始日期</p>
        /// </summary>
        [JsonProperty("StartDate")]
        public string StartDate{ get; set; }

        /// <summary>
        /// <p>结束日期</p>
        /// </summary>
        [JsonProperty("EndDate")]
        public string EndDate{ get; set; }

        /// <summary>
        /// <p>是否需要每日用量明细</p>
        /// </summary>
        [JsonProperty("NeedUsageDetails")]
        public bool? NeedUsageDetails{ get; set; }

        /// <summary>
        /// <p>环境id</p>
        /// </summary>
        [JsonProperty("EnvId")]
        public string EnvId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Modules.", this.Modules);
            this.SetParamSimple(map, prefix + "StartDate", this.StartDate);
            this.SetParamSimple(map, prefix + "EndDate", this.EndDate);
            this.SetParamSimple(map, prefix + "NeedUsageDetails", this.NeedUsageDetails);
            this.SetParamSimple(map, prefix + "EnvId", this.EnvId);
        }
    }
}

