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

    public class ModifySandboxAlertStatusRequest : AbstractModel
    {
        
        /// <summary>
        /// 告警类型
        /// 枚举值：
        /// ACL：访问控制
        /// DLP：数据泄露防护
        /// LLM_AUDIT：LLM 审计
        /// </summary>
        [JsonProperty("AlertType")]
        public string AlertType{ get; set; }

        /// <summary>
        /// 归属资产类型
        /// 枚举值：
        /// HOST：主机
        /// CONTAINER：容器
        /// </summary>
        [JsonProperty("BelongAssetType")]
        public string BelongAssetType{ get; set; }

        /// <summary>
        /// 告警记录 ID 列表
        /// 入参限制：非空，长度 1-100，去重后生效
        /// </summary>
        [JsonProperty("IDList")]
        public long?[] IDList{ get; set; }

        /// <summary>
        /// 目标操作
        /// 枚举值：
        /// HANDLED：已处理
        /// IGNORE：已忽略
        /// PASS：已加白
        /// DELETE：删除（不可恢复）
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AlertType", this.AlertType);
            this.SetParamSimple(map, prefix + "BelongAssetType", this.BelongAssetType);
            this.SetParamArraySimple(map, prefix + "IDList.", this.IDList);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

