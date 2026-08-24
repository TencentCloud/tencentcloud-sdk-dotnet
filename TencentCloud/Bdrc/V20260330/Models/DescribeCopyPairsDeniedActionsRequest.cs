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

namespace TencentCloud.Bdrc.V20260330.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCopyPairsDeniedActionsRequest : AbstractModel
    {
        
        /// <summary>
        /// 复制对ID列表
        /// </summary>
        [JsonProperty("CopyPairIds")]
        public string[] CopyPairIds{ get; set; }

        /// <summary>
        /// 要查询复制对的类型，枚举值：DISK（云硬盘）、INSTANCE（云服务器）、CFS（文件存储）
        /// </summary>
        [JsonProperty("CopyPairType")]
        public string CopyPairType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "CopyPairIds.", this.CopyPairIds);
            this.SetParamSimple(map, prefix + "CopyPairType", this.CopyPairType);
        }
    }
}

