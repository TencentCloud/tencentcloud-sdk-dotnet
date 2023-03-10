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

namespace TencentCloud.Irp.V20220805.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeGoodsRecommendRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例ID，在控制台获取
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 场景ID，在控制台创建场景后获取
        /// </summary>
        [JsonProperty("SceneId")]
        public string SceneId{ get; set; }

        /// <summary>
        /// 用户唯一ID，客户自定义用户ID，作为一个用户的唯一标识，需和行为数据上报接口中的UserId一致，否则影响特征关联
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// 用户设备ID数组，可传入用户的多个类型ID，用于关联画像信息
        /// </summary>
        [JsonProperty("UserIdList")]
        public StrUserIdInfo[] UserIdList{ get; set; }

        /// <summary>
        /// 推荐返回数量，默认10个，最多支持50个的内容返回。如果有更多数量要求，<a href="https://console.cloud.tencent.com/workorder/category" target="_blank">提单</a>沟通解决
        /// </summary>
        [JsonProperty("GoodsCnt")]
        public long? GoodsCnt{ get; set; }

        /// <summary>
        /// 当场景是相关推荐时该值必填，场景是非相关推荐时该值无效
        /// </summary>
        [JsonProperty("CurrentGoodsId")]
        public string CurrentGoodsId{ get; set; }

        /// <summary>
        /// 用户的实时特征信息，用作特征
        /// </summary>
        [JsonProperty("UserPortraitInfo")]
        public UserPortraitInfo UserPortraitInfo{ get; set; }

        /// <summary>
        /// 本次请求针对该用户需要过滤的物品列表(不超过100个)
        /// </summary>
        [JsonProperty("BlackGoodsList")]
        public string[] BlackGoodsList{ get; set; }

        /// <summary>
        /// json字符串，扩展字段
        /// </summary>
        [JsonProperty("Extension")]
        public string Extension{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "SceneId", this.SceneId);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamArrayObj(map, prefix + "UserIdList.", this.UserIdList);
            this.SetParamSimple(map, prefix + "GoodsCnt", this.GoodsCnt);
            this.SetParamSimple(map, prefix + "CurrentGoodsId", this.CurrentGoodsId);
            this.SetParamObj(map, prefix + "UserPortraitInfo.", this.UserPortraitInfo);
            this.SetParamArraySimple(map, prefix + "BlackGoodsList.", this.BlackGoodsList);
            this.SetParamSimple(map, prefix + "Extension", this.Extension);
        }
    }
}

