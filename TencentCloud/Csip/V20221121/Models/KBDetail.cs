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

    public class KBDetail : AbstractModel
    {
        
        /// <summary>
        /// <p>KB 补丁内部 ID（kb_info.id）</p>
        /// </summary>
        [JsonProperty("ID")]
        public ulong? ID{ get; set; }

        /// <summary>
        /// <p>KB 编号<br>参数格式：形如 KB5001234</p>
        /// </summary>
        [JsonProperty("Number")]
        public string Number{ get; set; }

        /// <summary>
        /// <p>KB 补丁名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>参考链接（微软官方文档地址）</p>
        /// </summary>
        [JsonProperty("ReferUrl")]
        public string ReferUrl{ get; set; }

        /// <summary>
        /// <p>发布时间<br>参数格式：YYYY-MM-DD HH:mm:ss</p>
        /// </summary>
        [JsonProperty("PublishTime")]
        public string PublishTime{ get; set; }

        /// <summary>
        /// <p>安装该 KB 后是否需要重启<br>枚举值：<br>true：需要<br>false：不需要</p>
        /// </summary>
        [JsonProperty("NeedRestart")]
        public bool? NeedRestart{ get; set; }

        /// <summary>
        /// <p>关联漏洞列表</p>
        /// </summary>
        [JsonProperty("RelateVulList")]
        public VulBriefInfo[] RelateVulList{ get; set; }

        /// <summary>
        /// <p>关联漏洞总数</p>
        /// </summary>
        [JsonProperty("RelateVulCount")]
        public long? RelateVulCount{ get; set; }

        /// <summary>
        /// <p>关联os版本</p>
        /// </summary>
        [JsonProperty("RelateProduct")]
        public string RelateProduct{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "Number", this.Number);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "ReferUrl", this.ReferUrl);
            this.SetParamSimple(map, prefix + "PublishTime", this.PublishTime);
            this.SetParamSimple(map, prefix + "NeedRestart", this.NeedRestart);
            this.SetParamArrayObj(map, prefix + "RelateVulList.", this.RelateVulList);
            this.SetParamSimple(map, prefix + "RelateVulCount", this.RelateVulCount);
            this.SetParamSimple(map, prefix + "RelateProduct", this.RelateProduct);
        }
    }
}

