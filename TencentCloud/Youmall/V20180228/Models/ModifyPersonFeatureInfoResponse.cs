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

    public class ModifyPersonFeatureInfoResponse : AbstractModel
    {
        
        /// <summary>
        /// 集团ID
        /// </summary>
        [JsonProperty("CompanyId")]
        public string CompanyId{ get; set; }

        /// <summary>
        /// 店铺ID，如果不填表示操作集团身份库
        /// </summary>
        [JsonProperty("ShopId")]
        public long? ShopId{ get; set; }

        /// <summary>
        /// 请求的顾客id
        /// </summary>
        [JsonProperty("PersonId")]
        public long? PersonId{ get; set; }

        /// <summary>
        /// 图片实际绑定person_id，可能与请求的person_id不同，以此id为准
        /// </summary>
        [JsonProperty("PersonIdBind")]
        public long? PersonIdBind{ get; set; }

        /// <summary>
        /// 请求的顾客类型
        /// </summary>
        [JsonProperty("PersonType")]
        public long? PersonType{ get; set; }

        /// <summary>
        /// 与请求的person_id类型相同、与请求图片特征相似的一个或多个person_id，需要额外确认这些id是否是同一个人
        /// </summary>
        [JsonProperty("SimilarPersonIds")]
        public long?[] SimilarPersonIds{ get; set; }

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
            this.SetParamSimple(map, prefix + "PersonIdBind", this.PersonIdBind);
            this.SetParamSimple(map, prefix + "PersonType", this.PersonType);
            this.SetParamArraySimple(map, prefix + "SimilarPersonIds.", this.SimilarPersonIds);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

