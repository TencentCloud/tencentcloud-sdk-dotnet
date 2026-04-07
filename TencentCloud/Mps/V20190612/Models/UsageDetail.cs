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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UsageDetail : AbstractModel
    {
        
        /// <summary>
        /// <p>广告配置uniq_id</p>
        /// </summary>
        [JsonProperty("UniqId")]
        public string UniqId{ get; set; }

        /// <summary>
        /// <p>广告配置id</p>
        /// </summary>
        [JsonProperty("ChannelId")]
        public string ChannelId{ get; set; }

        /// <summary>
        /// <p>广告配置名称</p>
        /// </summary>
        [JsonProperty("ChannelName")]
        public string ChannelName{ get; set; }

        /// <summary>
        /// <p>广告类型</p>
        /// </summary>
        [JsonProperty("AdType")]
        public string AdType{ get; set; }

        /// <summary>
        /// <p>广告请求成功数</p>
        /// </summary>
        [JsonProperty("AdRequestSuccess")]
        public ulong? AdRequestSuccess{ get; set; }

        /// <summary>
        /// <p>广告请求失败数</p>
        /// </summary>
        [JsonProperty("AdRequestFail")]
        public ulong? AdRequestFail{ get; set; }

        /// <summary>
        /// <p>广告曝光数</p>
        /// </summary>
        [JsonProperty("Impression")]
        public ulong? Impression{ get; set; }

        /// <summary>
        /// <p>广告开始播放数</p>
        /// </summary>
        [JsonProperty("Start")]
        public ulong? Start{ get; set; }

        /// <summary>
        /// <p>广告播放到1/4处数</p>
        /// </summary>
        [JsonProperty("FirstQuarter")]
        public ulong? FirstQuarter{ get; set; }

        /// <summary>
        /// <p>广告播放到1/2处数</p>
        /// </summary>
        [JsonProperty("Midpoint")]
        public ulong? Midpoint{ get; set; }

        /// <summary>
        /// <p>广告播放到3/4处数</p>
        /// </summary>
        [JsonProperty("ThirdQuarter")]
        public ulong? ThirdQuarter{ get; set; }

        /// <summary>
        /// <p>广告播放完成数</p>
        /// </summary>
        [JsonProperty("Complete")]
        public ulong? Complete{ get; set; }

        /// <summary>
        /// <p>中贴广告标记时间</p>
        /// </summary>
        [JsonProperty("AdMarkerTime")]
        public float? AdMarkerTime{ get; set; }

        /// <summary>
        /// <p>中贴个性化替换时间</p>
        /// </summary>
        [JsonProperty("ReplacedTime")]
        public float? ReplacedTime{ get; set; }

        /// <summary>
        /// <p>中贴个性化广告填充率</p>
        /// </summary>
        [JsonProperty("MidFillRate")]
        public float? MidFillRate{ get; set; }

        /// <summary>
        /// <p>前贴广告请求数</p>
        /// </summary>
        [JsonProperty("PreReqNum")]
        public ulong? PreReqNum{ get; set; }

        /// <summary>
        /// <p>前贴广告替换数</p>
        /// </summary>
        [JsonProperty("PreReplacedNum")]
        public ulong? PreReplacedNum{ get; set; }

        /// <summary>
        /// <p>前贴广告替换率</p>
        /// </summary>
        [JsonProperty("PreReplaceRate")]
        public float? PreReplaceRate{ get; set; }

        /// <summary>
        /// <p>在清单中发现了广告标记次数</p>
        /// </summary>
        [JsonProperty("ADMarkerFound")]
        public ulong? ADMarkerFound{ get; set; }

        /// <summary>
        /// <p>向ADS请求广告次数</p>
        /// </summary>
        [JsonProperty("MakeAdsRequest")]
        public ulong? MakeAdsRequest{ get; set; }

        /// <summary>
        /// <p>从ADS收到VAST返回次数</p>
        /// </summary>
        [JsonProperty("VASTResponse")]
        public ulong? VASTResponse{ get; set; }

        /// <summary>
        /// <p>成功填充了广告次数</p>
        /// </summary>
        [JsonProperty("FilledAvail")]
        public ulong? FilledAvail{ get; set; }

        /// <summary>
        /// <p>执行广告替换时遇到问题次数</p>
        /// </summary>
        [JsonProperty("WarningNoAd")]
        public ulong? WarningNoAd{ get; set; }

        /// <summary>
        /// <p>ADS返回超时次数</p>
        /// </summary>
        [JsonProperty("ErrorAdsTimeout")]
        public ulong? ErrorAdsTimeout{ get; set; }

        /// <summary>
        /// <p>ADS 返回了一个空的 VAST 响应次数</p>
        /// </summary>
        [JsonProperty("EmptyVASTResponse")]
        public ulong? EmptyVASTResponse{ get; set; }

        /// <summary>
        /// <p>ADS 返回了一个空的VMAP 响应次数</p>
        /// </summary>
        [JsonProperty("EmptyVMAPResponse")]
        public ulong? EmptyVMAPResponse{ get; set; }

        /// <summary>
        /// <p>日期</p>
        /// </summary>
        [JsonProperty("Date")]
        public string Date{ get; set; }

        /// <summary>
        /// <p>开始时间</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>结束时间</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UniqId", this.UniqId);
            this.SetParamSimple(map, prefix + "ChannelId", this.ChannelId);
            this.SetParamSimple(map, prefix + "ChannelName", this.ChannelName);
            this.SetParamSimple(map, prefix + "AdType", this.AdType);
            this.SetParamSimple(map, prefix + "AdRequestSuccess", this.AdRequestSuccess);
            this.SetParamSimple(map, prefix + "AdRequestFail", this.AdRequestFail);
            this.SetParamSimple(map, prefix + "Impression", this.Impression);
            this.SetParamSimple(map, prefix + "Start", this.Start);
            this.SetParamSimple(map, prefix + "FirstQuarter", this.FirstQuarter);
            this.SetParamSimple(map, prefix + "Midpoint", this.Midpoint);
            this.SetParamSimple(map, prefix + "ThirdQuarter", this.ThirdQuarter);
            this.SetParamSimple(map, prefix + "Complete", this.Complete);
            this.SetParamSimple(map, prefix + "AdMarkerTime", this.AdMarkerTime);
            this.SetParamSimple(map, prefix + "ReplacedTime", this.ReplacedTime);
            this.SetParamSimple(map, prefix + "MidFillRate", this.MidFillRate);
            this.SetParamSimple(map, prefix + "PreReqNum", this.PreReqNum);
            this.SetParamSimple(map, prefix + "PreReplacedNum", this.PreReplacedNum);
            this.SetParamSimple(map, prefix + "PreReplaceRate", this.PreReplaceRate);
            this.SetParamSimple(map, prefix + "ADMarkerFound", this.ADMarkerFound);
            this.SetParamSimple(map, prefix + "MakeAdsRequest", this.MakeAdsRequest);
            this.SetParamSimple(map, prefix + "VASTResponse", this.VASTResponse);
            this.SetParamSimple(map, prefix + "FilledAvail", this.FilledAvail);
            this.SetParamSimple(map, prefix + "WarningNoAd", this.WarningNoAd);
            this.SetParamSimple(map, prefix + "ErrorAdsTimeout", this.ErrorAdsTimeout);
            this.SetParamSimple(map, prefix + "EmptyVASTResponse", this.EmptyVASTResponse);
            this.SetParamSimple(map, prefix + "EmptyVMAPResponse", this.EmptyVMAPResponse);
            this.SetParamSimple(map, prefix + "Date", this.Date);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
        }
    }
}

