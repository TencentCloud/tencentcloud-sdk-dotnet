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

namespace TencentCloud.Irp.V20220324.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RecommendContentRequest : AbstractModel
    {
        
        /// <summary>
        /// 业务id
        /// </summary>
        [JsonProperty("Bid")]
        public string Bid{ get; set; }

        /// <summary>
        /// 场景id：比如有“猜你喜欢”，“热门内容”等推荐模块，每一个模块都有一个scene_id来表示。 在控制台创建场景后获取。需要跟行为上报时的id一致
        /// </summary>
        [JsonProperty("SceneId")]
        public string SceneId{ get; set; }

        /// <summary>
        /// 用户唯一ID数组，每个数组元素详见userId结构体，若不填，则接口返回热门结果
        /// </summary>
        [JsonProperty("UserIdList")]
        public UserIdInfo[] UserIdList{ get; set; }

        /// <summary>
        /// 会话id：必须和行为数据上报时所填写的traceId相同，用于行为数据来自于那次在线推荐请求的归因。**注意：此处如果没传，则响应会返回一个全局唯一ID返回给客户，并需客户透传给行为日志上报接口**
        /// </summary>
        [JsonProperty("RecTraceId")]
        public string RecTraceId{ get; set; }

        /// <summary>
        /// 推荐数量：物料优选的结果， 默认50个，目前最多支持200个的内容返回，如果返回个数更多，会影响性能，容易超时。
        /// </summary>
        [JsonProperty("ItemCnt")]
        public long? ItemCnt{ get; set; }

        /// <summary>
        /// 物料池id，用于召回该pool_id下的商品，如果有多个，用英文;分割。**注意：此处poolId需和物料上报时的poolIdList对应上**
        /// </summary>
        [JsonProperty("PoolId")]
        public string PoolId{ get; set; }

        /// <summary>
        /// 来源物料id，即用户当前浏览的物料id，用于在内容详情页获取关联推荐内容
        /// </summary>
        [JsonProperty("CurrentItemId")]
        public string CurrentItemId{ get; set; }

        /// <summary>
        /// 请求响应超时时间，单位ms，默认300ms，数值设置的过小，会影响推荐效果，最小支持250ms
        /// </summary>
        [JsonProperty("ResponseTimeout")]
        public long? ResponseTimeout{ get; set; }

        /// <summary>
        /// 返回结果中不同物料类型的比例，比例顺序需严格按照（图文，长视频，短视频，小视频）进行。只允许传[0,100]数字，多个请用**英文冒号**分割，且加起来不能超过100，以及比例数量不能超过**场景绑定的物料类型**（图文，长视频，短视频，小视频）数。**示例：**图文和短视频比例为40%:60%时，则填40:60图文和短视频比例为0%:100%时，则填0:100图文，长视频和短视频的比例为，图文占20%，剩余80%由长视频和短视频随机返回，则填20:80或仅填20均可
        /// </summary>
        [JsonProperty("ItemTypeRatio")]
        public string ItemTypeRatio{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Bid", this.Bid);
            this.SetParamSimple(map, prefix + "SceneId", this.SceneId);
            this.SetParamArrayObj(map, prefix + "UserIdList.", this.UserIdList);
            this.SetParamSimple(map, prefix + "RecTraceId", this.RecTraceId);
            this.SetParamSimple(map, prefix + "ItemCnt", this.ItemCnt);
            this.SetParamSimple(map, prefix + "PoolId", this.PoolId);
            this.SetParamSimple(map, prefix + "CurrentItemId", this.CurrentItemId);
            this.SetParamSimple(map, prefix + "ResponseTimeout", this.ResponseTimeout);
            this.SetParamSimple(map, prefix + "ItemTypeRatio", this.ItemTypeRatio);
        }
    }
}

