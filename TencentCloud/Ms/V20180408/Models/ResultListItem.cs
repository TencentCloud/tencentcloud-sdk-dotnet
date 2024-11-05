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

namespace TencentCloud.Ms.V20180408.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ResultListItem : AbstractModel
    {
        
        /// <summary>
        /// banner广告软件标记，分别为-1-不确定，0-否，1-是
        /// </summary>
        [JsonProperty("Banner")]
        public string Banner{ get; set; }

        /// <summary>
        /// 精品推荐列表广告标记，分别为-1-不确定，0-否，1-是
        /// </summary>
        [JsonProperty("BoutiqueRecommand")]
        public string BoutiqueRecommand{ get; set; }

        /// <summary>
        /// 悬浮窗图标广告标记,分别为-1-不确定，0-否，1-是
        /// </summary>
        [JsonProperty("FloatWindows")]
        public string FloatWindows{ get; set; }

        /// <summary>
        /// 积分墙广告软件标记，分别为 -1 -不确定，0-否，1-是
        /// </summary>
        [JsonProperty("IntegralWall")]
        public string IntegralWall{ get; set; }

        /// <summary>
        /// 安装包的md5
        /// </summary>
        [JsonProperty("Md5")]
        public string Md5{ get; set; }

        /// <summary>
        /// 通知栏广告软件标记，分别为-1-不确定，0-否，1-是
        /// </summary>
        [JsonProperty("NotifyBar")]
        public string NotifyBar{ get; set; }

        /// <summary>
        /// 1表示官方，0表示非官方
        /// </summary>
        [JsonProperty("Official")]
        public string Official{ get; set; }

        /// <summary>
        /// 广告插件结果列表
        /// </summary>
        [JsonProperty("PluginList")]
        public PluginListItem[] PluginList{ get; set; }

        /// <summary>
        /// 非广告插件结果列表(SDK、风险插件等)
        /// </summary>
        [JsonProperty("OptPluginList")]
        public OptPluginListItem[] OptPluginList{ get; set; }

        /// <summary>
        /// 数字类型，分别为0-未知， 1-安全软件，2-风险软件，3-病毒软件
        /// </summary>
        [JsonProperty("SafeType")]
        public string SafeType{ get; set; }

        /// <summary>
        /// Session id，合作方可以用来区分回调数据，需要唯一。
        /// </summary>
        [JsonProperty("Sid")]
        public string Sid{ get; set; }

        /// <summary>
        /// 安装包名称
        /// </summary>
        [JsonProperty("SoftName")]
        public string SoftName{ get; set; }

        /// <summary>
        /// 插播广告软件标记，取值：-1 不确定，0否， 1 是
        /// </summary>
        [JsonProperty("Spot")]
        public string Spot{ get; set; }

        /// <summary>
        /// 病毒名称，utf8编码
        /// </summary>
        [JsonProperty("VirusName")]
        public string VirusName{ get; set; }

        /// <summary>
        /// 病毒描述，utf8编码
        /// </summary>
        [JsonProperty("VirusDesc")]
        public string VirusDesc{ get; set; }

        /// <summary>
        /// 二次打包状态：0-表示默认；1-表示二次
        /// </summary>
        [JsonProperty("RepackageStatus")]
        public string RepackageStatus{ get; set; }

        /// <summary>
        /// 应用错误码：0、1-表示正常；                  
        /// 
        /// 2表示System Error(engine analysis error).
        /// 
        /// 3表示App analysis error, please confirm it.
        /// 
        /// 4表示App have not cert, please confirm it.
        /// 
        /// 5表示App size is zero, please confirm it.
        /// 
        /// 6表示App have not package name, please confirm it.
        /// 
        /// 7表示App build time is empty, please confirm it.
        /// 
        /// 8表示App have not valid cert, please confirm it.
        /// 
        /// 99表示Other error.
        /// 
        /// 1000表示App downloadlink download fail, please confirm it.
        /// 
        /// 1001表示APP md5 different between real md5, please confirm it.
        /// 
        /// 1002表示App md5 uncollect, please offer downloadlink.
        /// </summary>
        [JsonProperty("Errno")]
        [System.Obsolete]
        public string Errno{ get; set; }

        /// <summary>
        /// 对应errno的错误信息描述
        /// </summary>
        [JsonProperty("ErrMsg")]
        public string ErrMsg{ get; set; }

        /// <summary>
        /// 应用错误码：0、1-表示正常；                  
        /// 
        /// 2表示System Error(engine analysis error).
        /// 
        /// 3表示App analysis error, please confirm it.
        /// 
        /// 4表示App have not cert, please confirm it.
        /// 
        /// 5表示App size is zero, please confirm it.
        /// 
        /// 6表示App have not package name, please confirm it.
        /// 
        /// 7表示App build time is empty, please confirm it.
        /// 
        /// 8表示App have not valid cert, please confirm it.
        /// 
        /// 99表示Other error.
        /// 
        /// 1000表示App downloadlink download fail, please confirm it.
        /// 
        /// 1001表示APP md5 different between real md5, please confirm it.
        /// 
        /// 1002表示App md5 uncollect, please offer downloadlink.
        /// </summary>
        [JsonProperty("ErrNo")]
        public string ErrNo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Banner", this.Banner);
            this.SetParamSimple(map, prefix + "BoutiqueRecommand", this.BoutiqueRecommand);
            this.SetParamSimple(map, prefix + "FloatWindows", this.FloatWindows);
            this.SetParamSimple(map, prefix + "IntegralWall", this.IntegralWall);
            this.SetParamSimple(map, prefix + "Md5", this.Md5);
            this.SetParamSimple(map, prefix + "NotifyBar", this.NotifyBar);
            this.SetParamSimple(map, prefix + "Official", this.Official);
            this.SetParamArrayObj(map, prefix + "PluginList.", this.PluginList);
            this.SetParamArrayObj(map, prefix + "OptPluginList.", this.OptPluginList);
            this.SetParamSimple(map, prefix + "SafeType", this.SafeType);
            this.SetParamSimple(map, prefix + "Sid", this.Sid);
            this.SetParamSimple(map, prefix + "SoftName", this.SoftName);
            this.SetParamSimple(map, prefix + "Spot", this.Spot);
            this.SetParamSimple(map, prefix + "VirusName", this.VirusName);
            this.SetParamSimple(map, prefix + "VirusDesc", this.VirusDesc);
            this.SetParamSimple(map, prefix + "RepackageStatus", this.RepackageStatus);
            this.SetParamSimple(map, prefix + "Errno", this.Errno);
            this.SetParamSimple(map, prefix + "ErrMsg", this.ErrMsg);
            this.SetParamSimple(map, prefix + "ErrNo", this.ErrNo);
        }
    }
}

