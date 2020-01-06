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

    public class DescribePersonInfoByFacePictureResponse : AbstractModel
    {
        
        /// <summary>
        /// 集团id
        /// </summary>
        [JsonProperty("CompanyId")]
        public string CompanyId{ get; set; }

        /// <summary>
        /// 店铺id
        /// </summary>
        [JsonProperty("ShopId")]
        public long? ShopId{ get; set; }

        /// <summary>
        /// 顾客face id
        /// </summary>
        [JsonProperty("PersonId")]
        public long? PersonId{ get; set; }

        /// <summary>
        /// 顾客底图url
        /// </summary>
        [JsonProperty("PictureUrl")]
        public string PictureUrl{ get; set; }

        /// <summary>
        /// 顾客类型（0表示普通顾客，1 白名单，2 表示黑名单，101表示集团白名单，102表示集团黑名单）
        /// </summary>
        [JsonProperty("PersonType")]
        public long? PersonType{ get; set; }

        /// <summary>
        /// 顾客首次进店时间
        /// </summary>
        [JsonProperty("FirstVisitTime")]
        public string FirstVisitTime{ get; set; }

        /// <summary>
        /// 顾客历史到访次数
        /// </summary>
        [JsonProperty("VisitTimes")]
        public long? VisitTimes{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CompanyId", this.CompanyId);
            this.SetParamSimple(map, prefix + "ShopId", this.ShopId);
            this.SetParamSimple(map, prefix + "PersonId", this.PersonId);
            this.SetParamSimple(map, prefix + "PictureUrl", this.PictureUrl);
            this.SetParamSimple(map, prefix + "PersonType", this.PersonType);
            this.SetParamSimple(map, prefix + "FirstVisitTime", this.FirstVisitTime);
            this.SetParamSimple(map, prefix + "VisitTimes", this.VisitTimes);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

