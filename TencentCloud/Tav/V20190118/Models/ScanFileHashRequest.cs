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

namespace TencentCloud.Tav.V20190118.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ScanFileHashRequest : AbstractModel
    {
        
        /// <summary>
        /// 购买服务后获得的授权信息，用于保证请求有效性
        /// </summary>
        [JsonProperty("Key")]
        public string Key{ get; set; }

        /// <summary>
        /// 需要查询的md5值（支持单个和多个，多个md5间用逗号分格）
        /// </summary>
        [JsonProperty("Md5s")]
        public string Md5s{ get; set; }

        /// <summary>
        /// 保留字段默认填0
        /// </summary>
        [JsonProperty("WithCategory")]
        public string WithCategory{ get; set; }

        /// <summary>
        /// 松严规则控制字段默认填10（5-松、10-标准、15-严）
        /// </summary>
        [JsonProperty("SensitiveLevel")]
        public string SensitiveLevel{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Key", this.Key);
            this.SetParamSimple(map, prefix + "Md5s", this.Md5s);
            this.SetParamSimple(map, prefix + "WithCategory", this.WithCategory);
            this.SetParamSimple(map, prefix + "SensitiveLevel", this.SensitiveLevel);
        }
    }
}

