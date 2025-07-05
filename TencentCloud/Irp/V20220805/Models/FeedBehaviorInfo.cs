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

    public class FeedBehaviorInfo : AbstractModel
    {
        
        /// <summary>
        /// 用户唯一ID，客户自定义用户ID，作为一个用户的唯一标识
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// 内容唯一id
        /// </summary>
        [JsonProperty("ItemId")]
        public string ItemId{ get; set; }

        /// <summary>
        /// 行为类型：<br> ● expose - 曝光，<b>必须</b><br> ● click - 点击，<b>必须</b><br/>  ● stay - 详情页停留时长，<b>强烈建议</b><br/>  ● videoover - 视频播放时长，<b>强烈建议</b><br/> ●  like - 点赞&喜欢，<b>正效果</b><br/> ● collect - 收藏，<b>正效果</b><br/> ●  share - 转发&分享，<b>正效果</b><br/> ● reward - 打赏，<b>正效果</b><br/> ● unlike - 踩&不喜欢，<b>负效果</b><br/> ●  comment - 评论<br/> 不支持的行为类型，可以映射到未被使用的其他行为类型。如实际业务数据中有私信行为，没有收藏行为，可以将私信行为映射到收藏行为
        /// </summary>
        [JsonProperty("BehaviorType")]
        public string BehaviorType{ get; set; }

        /// <summary>
        /// 行为类型对应的行为值：<br/> ● expose - 曝光，固定填1<br/> ● click - 点击，固定填1<br/>  ● stay - 详情页停留时长，填停留秒数，取值[1-86400]<br/>  ● videoover - 视频播放时长，填播放结束的秒数，取值[1-86400]<br/> ●  like - 点赞&喜欢，固定填1<br/> ● collect - 收藏，固定填1<br/> ●  share - 转发&分享，固定填1<br/> ● reward - 打赏，填打赏金额，没有则填1<br/> ● unlike - 踩&不喜欢，填不喜欢的原因，没有则填1<br/> ●  comment - 评论，填评论内容，如“上海加油”
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
        /// 推荐追踪ID，使用推荐结果中返回的ItemTraceId填入。 
        /// 注意：如果和推荐结果中的ItemTraceId不同，会影响行为特征归因，影响推荐算法效果
        /// </summary>
        [JsonProperty("ItemTraceId")]
        public string ItemTraceId{ get; set; }

        /// <summary>
        /// 内容类型，跟内容上报类型一致，用于效果分析，不做内容校验，<b>强烈建议</b>
        /// </summary>
        [JsonProperty("ItemType")]
        public string ItemType{ get; set; }

        /// <summary>
        /// 相关推荐场景点击进入详情页的内容id，该字段用来注明行为发生于哪个内容的详情页推荐中，<b>相关推荐场景强烈建议</b>
        /// </summary>
        [JsonProperty("ReferrerItemId")]
        public string ReferrerItemId{ get; set; }

        /// <summary>
        /// 用户设备ID数组，可传入用户的多个类型ID，详见UserIdInfo结构体，建议补齐，<b>用于构建用户画像信息</b>
        /// </summary>
        [JsonProperty("UserIdList")]
        public UserIdInfo[] UserIdList{ get; set; }

        /// <summary>
        /// 算法来源： <br>● business 业务自己的算法对照组<br/> ● tencent 腾讯算法<br/> ● other 其他算法<br/>默认为tencent，区分行为来源于哪个算法，<b>用于Poc阶段的效果对比验证</b>
        /// </summary>
        [JsonProperty("Source")]
        public string Source{ get; set; }

        /// <summary>
        /// 行为发生时的国家，ISO 3166-1 alpha-2编码，参考<a href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2" target="_blank">ISO 3166-1 alpha-2</a>，中国：“CN”，<b>用作特征</b>
        /// </summary>
        [JsonProperty("Country")]
        public string Country{ get; set; }

        /// <summary>
        /// 行为发生时的省份，ISO 3166-2行政区编码，如中国参考<a href="https://zh.wikipedia.org/wiki/ISO_3166-2:CN" target="_blank">ISO_3166-2:CN</a>，广东省：“CN-GD”，<b>用作特征</b>
        /// </summary>
        [JsonProperty("Province")]
        public string Province{ get; set; }

        /// <summary>
        /// 行为发生时的城市地区，统一用国家最新标准地区行政编码，如：<a href="https://www.mca.gov.cn/article/sj/xzqh/2020/" target="_blank">2020年行政区编码</a>，其他国家统一用国际公认城市简称或者城市编码，<b>用作特征</b>
        /// </summary>
        [JsonProperty("City")]
        public string City{ get; set; }

        /// <summary>
        /// 行为发生时的客户端ip，<b>用作特征</b>
        /// </summary>
        [JsonProperty("IP")]
        public string IP{ get; set; }

        /// <summary>
        /// 行为发生时的客户端网络类型，<b>用作特征</b>
        /// </summary>
        [JsonProperty("Network")]
        public string Network{ get; set; }

        /// <summary>
        /// 行为发生时的客户端平台，ios/android/h5，<b>用作特征</b>
        /// </summary>
        [JsonProperty("Platform")]
        public string Platform{ get; set; }

        /// <summary>
        /// 行为发生时的客户端app版本，<b>用作特征</b>
        /// </summary>
        [JsonProperty("AppVersion")]
        public string AppVersion{ get; set; }

        /// <summary>
        /// 行为发生时的操作系统版本，<b>用作特征</b>
        /// </summary>
        [JsonProperty("OsVersion")]
        public string OsVersion{ get; set; }

        /// <summary>
        /// 行为发生时的机型，<b>用作特征</b>
        /// </summary>
        [JsonProperty("DeviceModel")]
        public string DeviceModel{ get; set; }

        /// <summary>
        /// json字符串，<b>用于行为数据的扩展</b>，需要base64加密
        /// </summary>
        [JsonProperty("Extension")]
        public string Extension{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "ItemId", this.ItemId);
            this.SetParamSimple(map, prefix + "BehaviorType", this.BehaviorType);
            this.SetParamSimple(map, prefix + "BehaviorValue", this.BehaviorValue);
            this.SetParamSimple(map, prefix + "BehaviorTimestamp", this.BehaviorTimestamp);
            this.SetParamSimple(map, prefix + "SceneId", this.SceneId);
            this.SetParamSimple(map, prefix + "ItemTraceId", this.ItemTraceId);
            this.SetParamSimple(map, prefix + "ItemType", this.ItemType);
            this.SetParamSimple(map, prefix + "ReferrerItemId", this.ReferrerItemId);
            this.SetParamArrayObj(map, prefix + "UserIdList.", this.UserIdList);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "Country", this.Country);
            this.SetParamSimple(map, prefix + "Province", this.Province);
            this.SetParamSimple(map, prefix + "City", this.City);
            this.SetParamSimple(map, prefix + "IP", this.IP);
            this.SetParamSimple(map, prefix + "Network", this.Network);
            this.SetParamSimple(map, prefix + "Platform", this.Platform);
            this.SetParamSimple(map, prefix + "AppVersion", this.AppVersion);
            this.SetParamSimple(map, prefix + "OsVersion", this.OsVersion);
            this.SetParamSimple(map, prefix + "DeviceModel", this.DeviceModel);
            this.SetParamSimple(map, prefix + "Extension", this.Extension);
        }
    }
}

