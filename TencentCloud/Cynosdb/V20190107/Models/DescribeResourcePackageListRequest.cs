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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeResourcePackageListRequest : AbstractModel
    {
        
        /// <summary>
        /// 资源包唯一ID
        /// </summary>
        [JsonProperty("PackageId")]
        public string[] PackageId{ get; set; }

        /// <summary>
        /// 资源包名称
        /// </summary>
        [JsonProperty("PackageName")]
        public string[] PackageName{ get; set; }

        /// <summary>
        /// 资源包类型
        /// CCU-计算资源包，DISK-存储资源包
        /// </summary>
        [JsonProperty("PackageType")]
        public string[] PackageType{ get; set; }

        /// <summary>
        /// 资源包使用地域
        /// china-中国内地通用，overseas-港澳台及海外通用
        /// </summary>
        [JsonProperty("PackageRegion")]
        public string[] PackageRegion{ get; set; }

        /// <summary>
        /// 资源包状态
        /// creating-创建中；
        /// using-使用中；
        /// expired-已过期；
        /// normal_finish-使用完；
        /// apply_refund-申请退费中；
        /// refund-已退费。
        /// </summary>
        [JsonProperty("Status")]
        public string[] Status{ get; set; }

        /// <summary>
        /// 排序条件，支持排序条件:startTime-生效时间，
        /// expireTime-过期时间，packageUsedSpec-使用容量，packageTotalSpec-总存储量。
        /// 按照数组顺序排列；
        /// </summary>
        [JsonProperty("OrderBy")]
        public string[] OrderBy{ get; set; }

        /// <summary>
        /// 排序方式，DESC-降序，ASC-升序
        /// </summary>
        [JsonProperty("OrderDirection")]
        public string OrderDirection{ get; set; }

        /// <summary>
        /// 偏移量
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 限制
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "PackageId.", this.PackageId);
            this.SetParamArraySimple(map, prefix + "PackageName.", this.PackageName);
            this.SetParamArraySimple(map, prefix + "PackageType.", this.PackageType);
            this.SetParamArraySimple(map, prefix + "PackageRegion.", this.PackageRegion);
            this.SetParamArraySimple(map, prefix + "Status.", this.Status);
            this.SetParamArraySimple(map, prefix + "OrderBy.", this.OrderBy);
            this.SetParamSimple(map, prefix + "OrderDirection", this.OrderDirection);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

