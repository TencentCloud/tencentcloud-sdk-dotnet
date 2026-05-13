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

    public class DescribeSkillScanResultRequest : AbstractModel
    {
        
        /// <summary>
        /// ZIP 文件的 SHA256 Hash
        /// 参数格式：sha256:<64位hex>
        /// </summary>
        [JsonProperty("ContentHash")]
        public string ContentHash{ get; set; }

        /// <summary>
        /// 指定引擎版本号
        /// 取值参考：由 CreateSkillScan 接口返回
        /// </summary>
        [JsonProperty("EngineVersion")]
        public long? EngineVersion{ get; set; }

        /// <summary>
        /// 报告签名地址有效期
        /// 单位：小时
        /// 默认值：8760（1年）
        /// 补充说明：对返回的 ReportURL 生效
        /// </summary>
        [JsonProperty("ReportURLExpireHours")]
        public long? ReportURLExpireHours{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ContentHash", this.ContentHash);
            this.SetParamSimple(map, prefix + "EngineVersion", this.EngineVersion);
            this.SetParamSimple(map, prefix + "ReportURLExpireHours", this.ReportURLExpireHours);
        }
    }
}

