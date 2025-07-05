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

namespace TencentCloud.Irp.V20220805.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GoodsBehaviorInfo : AbstractModel
    {
        
        /// <summary>
        /// 用户唯一ID，客户自定义用户ID，作为一个用户的唯一标识
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// 商品唯一ID，skuId或spuId，客户根据需求自行决定商品主键粒度
        /// </summary>
        [JsonProperty("GoodsId")]
        public string GoodsId{ get; set; }

        /// <summary>
        /// 行为类型：<br> ● expose - 曝光，<b>必须</b><br> ● click - 点击，<b>必须</b><br/>  ● stay - 详情页停留时长，<b>强烈建议</b><br/>  ● videoover - 视频播放时长，<b>强烈建议</b><br/> ●  like - 点赞&喜欢，<b>正效果</b><br/> ● collect - 收藏，<b>正效果</b><br/> ●  share - 转发&分享，<b>正效果</b><br/> ● reward - 打赏，<b>正效果</b><br/> ● unlike - 踩&不喜欢，<b>负效果</b><br/> ●  comment - 评论<br/> ●  order - 下单<br/> ●  buy - 购买成功<br/> ●  addcart - 加入购物车<br/>   
        /// 不支持的行为类型，可以映射到未被使用的其他行为类型。如实际业务数据中有私信行为，没有收藏行为，可以将私信行为映射到收藏行为
        /// </summary>
        [JsonProperty("BehaviorType")]
        public string BehaviorType{ get; set; }

        /// <summary>
        /// 行为类型对应的行为值：<br/> ● expose - 曝光，固定填1<br/> ● click - 点击，固定填1<br/>  ● stay - 详情页停留时长，填停留秒数，取值[1-86400]<br/>  ● videoover - 视频播放时长，填播放结束的秒数，取值[1-86400]<br/> ●  like - 点赞&喜欢，固定填1<br/> ● collect - 收藏，固定填1<br/> ●  share - 转发&分享，固定填1<br/> ● reward - 打赏，填打赏金额，没有则填1<br/> ● unlike - 踩&不喜欢，填不喜欢的原因，没有则填1<br/> ●  comment - 评论，填评论内容，如“上海加油”<br/> ●  order - 下单，固定填1<br/> ●  buy - 购买成功，固定填1<br/> ●  addcart - 加入购物车，固定填1
        /// </summary>
        [JsonProperty("BehaviorValue")]
        public string BehaviorValue{ get; set; }

        /// <summary>
        /// 行为发生的时间戳： 秒级时间戳，尽量实时上报，最长不超过半小时否则会影响推荐结果的准确性
        /// </summary>
        [JsonProperty("BehaviorTimestamp")]
        public long? BehaviorTimestamp{ get; set; }

        /// <summary>
        /// 行为发生的场景ID，在控制台创建场景后获取
        /// </summary>
        [JsonProperty("SceneId")]
        public string SceneId{ get; set; }

        /// <summary>
        /// 算法来源： <br>● business 业务自己的算法对照组<br/> ● tencent 腾讯算法<br/> ● other 其他算法<br/>默认为tencent，区分行为来源于哪个算法，<b>用于Poc阶段的效果对比验证</b>
        /// </summary>
        [JsonProperty("Source")]
        public string Source{ get; set; }

        /// <summary>
        /// 标识行为发生在app内哪个页面，取值客户自定，可以是明文或id，建议传明文便于理解、分析，如首页，发现页，用户中心等
        /// <b>用作上下文特征，刻画不同场景用户行为分布的差异</b>
        /// </summary>
        [JsonProperty("Page")]
        public string Page{ get; set; }

        /// <summary>
        /// 标识行为发生在页面的哪一区块，取值客户自定，可以是明文或id，建议传明文便于理解、分析，如横幅、广告位、猜你喜欢等
        /// <b>用作上下文特征，刻画不同模块用户行为分布的差异</b>
        /// </summary>
        [JsonProperty("Module")]
        public string Module{ get; set; }

        /// <summary>
        /// 推荐追踪ID，使用推荐结果中返回的GoodsTraceId填入。 
        /// 注意：如果和推荐结果中的GoodsTraceId不同，会影响行为特征归因，影响推荐算法效果。<b>强烈建议</b>
        /// </summary>
        [JsonProperty("GoodsTraceId")]
        public string GoodsTraceId{ get; set; }

        /// <summary>
        /// 相关推荐场景点击进入详情页的内容id，该字段用来注明行为发生于哪个内容的详情页推荐中，<b>相关推荐场景强烈建议</b>
        /// </summary>
        [JsonProperty("ReferrerGoodsId")]
        public string ReferrerGoodsId{ get; set; }

        /// <summary>
        /// 订单商品购买个数，当behaviorType=order，buy或addcart时有值，<b>用作特征</b>
        /// </summary>
        [JsonProperty("OrderGoodsCnt")]
        public long? OrderGoodsCnt{ get; set; }

        /// <summary>
        /// 订单总金额，当behaviorType=order或buy时有值（单位：元，统一货币体系，如统一为RMB，美元等），<b>用作特征</b>
        /// </summary>
        [JsonProperty("OrderAmount")]
        public float? OrderAmount{ get; set; }

        /// <summary>
        /// 用户设备ID数组，可传入用户的多个类型ID，详见UserIdInfo结构体，建议补齐，<b>用于构建用户画像信息</b>
        /// </summary>
        [JsonProperty("UserIdList")]
        public StrUserIdInfo[] UserIdList{ get; set; }

        /// <summary>
        /// 行为发生时用户基础特征信息，<b>用作特征</b>
        /// </summary>
        [JsonProperty("UserPortraitInfo")]
        public UserPortraitInfo UserPortraitInfo{ get; set; }

        /// <summary>
        /// 标识行为发生在模块内的具体位置，如1、2、...
        /// <b>用作上下文特征，刻画不同位置用户行为分布的差异</b>
        /// </summary>
        [JsonProperty("Position")]
        public long? Position{ get; set; }

        /// <summary>
        /// json字符串，<b>用于行为数据的扩展</b>
        /// </summary>
        [JsonProperty("Extension")]
        public string Extension{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "GoodsId", this.GoodsId);
            this.SetParamSimple(map, prefix + "BehaviorType", this.BehaviorType);
            this.SetParamSimple(map, prefix + "BehaviorValue", this.BehaviorValue);
            this.SetParamSimple(map, prefix + "BehaviorTimestamp", this.BehaviorTimestamp);
            this.SetParamSimple(map, prefix + "SceneId", this.SceneId);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "Page", this.Page);
            this.SetParamSimple(map, prefix + "Module", this.Module);
            this.SetParamSimple(map, prefix + "GoodsTraceId", this.GoodsTraceId);
            this.SetParamSimple(map, prefix + "ReferrerGoodsId", this.ReferrerGoodsId);
            this.SetParamSimple(map, prefix + "OrderGoodsCnt", this.OrderGoodsCnt);
            this.SetParamSimple(map, prefix + "OrderAmount", this.OrderAmount);
            this.SetParamArrayObj(map, prefix + "UserIdList.", this.UserIdList);
            this.SetParamObj(map, prefix + "UserPortraitInfo.", this.UserPortraitInfo);
            this.SetParamSimple(map, prefix + "Position", this.Position);
            this.SetParamSimple(map, prefix + "Extension", this.Extension);
        }
    }
}

