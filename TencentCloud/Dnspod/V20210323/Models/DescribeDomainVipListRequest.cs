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

namespace TencentCloud.Dnspod.V20210323.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDomainVipListRequest : AbstractModel
    {
        
        /// <summary>
        /// 偏移量，默认值为0。
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 限制数量，默认值为20。
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 通过关键字搜索域名关联的套餐，默认值为空，为空时不作为筛选条件。
        /// </summary>
        [JsonProperty("Keyword")]
        public string Keyword{ get; set; }

        /// <summary>
        /// 使用资源ID列表查询
        /// </summary>
        [JsonProperty("ResourceIdList")]
        public string[] ResourceIdList{ get; set; }

        /// <summary>
        /// 需要筛选的套餐版本
        /// </summary>
        [JsonProperty("GradeList")]
        public string[] GradeList{ get; set; }

        /// <summary>
        /// 是否只获取未绑定域名套餐
        /// </summary>
        [JsonProperty("GetUnbindResource")]
        public bool? GetUnbindResource{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Keyword", this.Keyword);
            this.SetParamArraySimple(map, prefix + "ResourceIdList.", this.ResourceIdList);
            this.SetParamArraySimple(map, prefix + "GradeList.", this.GradeList);
            this.SetParamSimple(map, prefix + "GetUnbindResource", this.GetUnbindResource);
        }
    }
}

