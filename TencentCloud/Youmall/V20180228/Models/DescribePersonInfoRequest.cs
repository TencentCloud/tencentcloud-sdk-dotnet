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

namespace TencentCloud.Youmall.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribePersonInfoRequest : AbstractModel
    {
        
        /// <summary>
        /// 公司ID
        /// </summary>
        [JsonProperty("CompanyId")]
        public string CompanyId{ get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [JsonProperty("ShopId")]
        public ulong? ShopId{ get; set; }

        /// <summary>
        /// 起始ID，第一次拉取时StartPersonId传0，后续送入的值为上一页最后一条数据项的PersonId
        /// </summary>
        [JsonProperty("StartPersonId")]
        public ulong? StartPersonId{ get; set; }

        /// <summary>
        /// 偏移量：分页控制参数，第一页传0，第n页Offset=(n-1)*Limit
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Limit:每页的数据项，最大100，超过100会被强制指定为100
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 图片url过期时间：在当前时间+PictureExpires秒后，图片url无法继续正常访问；单位s；默认值1*24*60*60（1天）
        /// </summary>
        [JsonProperty("PictureExpires")]
        public ulong? PictureExpires{ get; set; }

        /// <summary>
        /// 身份类型(0表示普通顾客，1 白名单，2 表示黑名单）
        /// </summary>
        [JsonProperty("PersonType")]
        public ulong? PersonType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CompanyId", this.CompanyId);
            this.SetParamSimple(map, prefix + "ShopId", this.ShopId);
            this.SetParamSimple(map, prefix + "StartPersonId", this.StartPersonId);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "PictureExpires", this.PictureExpires);
            this.SetParamSimple(map, prefix + "PersonType", this.PersonType);
        }
    }
}

