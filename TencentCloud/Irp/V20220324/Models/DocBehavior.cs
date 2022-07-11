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

    public class DocBehavior : AbstractModel
    {
        
        /// <summary>
        /// 内容唯一ID，如 2824324234
        /// </summary>
        [JsonProperty("ItemId")]
        public string ItemId{ get; set; }

        /// <summary>
        /// 行为类型
        /// </summary>
        [JsonProperty("BehaviorType")]
        public long? BehaviorType{ get; set; }

        /// <summary>
        /// 行为值
        /// </summary>
        [JsonProperty("BehaviorValue")]
        public string BehaviorValue{ get; set; }

        /// <summary>
        /// 行为时间戳： 秒级时间戳（默认为当前时间）,不能延迟太久，尽量实时上报，否则会影响推荐结果的准确性。
        /// </summary>
        [JsonProperty("BehaviorTimestamp")]
        public long? BehaviorTimestamp{ get; set; }

        /// <summary>
        /// 场景id，在控制台创建场景后获取。
        /// </summary>
        [JsonProperty("SceneId")]
        public string SceneId{ get; set; }

        /// <summary>
        /// 用户id列表
        /// </summary>
        [JsonProperty("UserIdList")]
        public UserIdInfo[] UserIdList{ get; set; }

        /// <summary>
        /// 会话id，使用获取推荐结果中返回的RecTraceId填入。<br>注意：如果和在线推荐请求中的traceId不同，会影响行为特征归因，影响推荐算法效果
        /// </summary>
        [JsonProperty("RecTraceId")]
        public string RecTraceId{ get; set; }

        /// <summary>
        /// 算法来源：用来区分行为来源于哪个算法。值为**business，tencent，other** 三者之一<br>● business 表示业务自己的算法对照组<br>● tencent 为腾讯算法<br>● other 为其他算法
        /// </summary>
        [JsonProperty("Source")]
        public string Source{ get; set; }

        /// <summary>
        /// 物料类型
        /// </summary>
        [JsonProperty("ItemType")]
        public long? ItemType{ get; set; }

        /// <summary>
        /// 微信开放平台上查看appId
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// 回传video_over事件的时候，回传的用户播放视频的总时长（真正播放的，拖动不算，单位为秒）
        /// </summary>
        [JsonProperty("VideoPlayDuration")]
        public long? VideoPlayDuration{ get; set; }

        /// <summary>
        /// 来源物料内容：用来标识在指定内容页面产生的行为，如需要统计用户在A内容详情页里，对推荐内容B点击等行为，则ReferrerItemId代表内容A，ItemId代表内容B
        /// </summary>
        [JsonProperty("ReferrerItemId")]
        public string ReferrerItemId{ get; set; }

        /// <summary>
        /// 国家，统一用简写，比如中国则填写CN
        /// </summary>
        [JsonProperty("Country")]
        public string Country{ get; set; }

        /// <summary>
        /// 省
        /// </summary>
        [JsonProperty("Province")]
        public string Province{ get; set; }

        /// <summary>
        /// 城市
        /// </summary>
        [JsonProperty("City")]
        public string City{ get; set; }

        /// <summary>
        /// 区县
        /// </summary>
        [JsonProperty("District")]
        public string District{ get; set; }

        /// <summary>
        /// 客户端ip
        /// </summary>
        [JsonProperty("IP")]
        public string IP{ get; set; }

        /// <summary>
        /// 客户端网络类型
        /// </summary>
        [JsonProperty("Network")]
        public string Network{ get; set; }

        /// <summary>
        /// 客户端平台，ios/android/h5
        /// </summary>
        [JsonProperty("Platform")]
        public string Platform{ get; set; }

        /// <summary>
        /// 客户端app版本
        /// </summary>
        [JsonProperty("AppVersion")]
        public string AppVersion{ get; set; }

        /// <summary>
        /// 操作系统版本
        /// </summary>
        [JsonProperty("OsVersion")]
        public string OsVersion{ get; set; }

        /// <summary>
        /// 机型
        /// </summary>
        [JsonProperty("DeviceModel")]
        public string DeviceModel{ get; set; }

        /// <summary>
        /// json字符串，用于行为数据的扩展
        /// </summary>
        [JsonProperty("Extension")]
        public string Extension{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ItemId", this.ItemId);
            this.SetParamSimple(map, prefix + "BehaviorType", this.BehaviorType);
            this.SetParamSimple(map, prefix + "BehaviorValue", this.BehaviorValue);
            this.SetParamSimple(map, prefix + "BehaviorTimestamp", this.BehaviorTimestamp);
            this.SetParamSimple(map, prefix + "SceneId", this.SceneId);
            this.SetParamArrayObj(map, prefix + "UserIdList.", this.UserIdList);
            this.SetParamSimple(map, prefix + "RecTraceId", this.RecTraceId);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "ItemType", this.ItemType);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "VideoPlayDuration", this.VideoPlayDuration);
            this.SetParamSimple(map, prefix + "ReferrerItemId", this.ReferrerItemId);
            this.SetParamSimple(map, prefix + "Country", this.Country);
            this.SetParamSimple(map, prefix + "Province", this.Province);
            this.SetParamSimple(map, prefix + "City", this.City);
            this.SetParamSimple(map, prefix + "District", this.District);
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

