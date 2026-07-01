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

namespace TencentCloud.Rum.V20210622.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDataPvUrlStatisticsV2Request : AbstractModel
    {
        
        /// <summary>
        /// <p>开始时间</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public long? StartTime{ get; set; }

        /// <summary>
        /// <p>allcount：性能视图，day：14天数据，vp：性能，ckuv：uv，ckpv：pv，condition：条件列表，nettype/version/platform/isp/region/device/browser/ext1/ext2/ext3/ret/status/from/url/env/：网络平台视图/Version视图/设备视图/ISP视图/地区视图/浏览器视图/ext1视图等</p>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>结束时间</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public long? EndTime{ get; set; }

        /// <summary>
        /// <p>项目ID</p>
        /// </summary>
        [JsonProperty("ID")]
        public long? ID{ get; set; }

        /// <summary>
        /// <p>自定义2</p>
        /// </summary>
        [JsonProperty("ExtSecond")]
        public string ExtSecond{ get; set; }

        /// <summary>
        /// <p>浏览器引擎</p>
        /// </summary>
        [JsonProperty("Engine")]
        public string Engine{ get; set; }

        /// <summary>
        /// <p>运营商</p>
        /// </summary>
        [JsonProperty("Isp")]
        public string Isp{ get; set; }

        /// <summary>
        /// <p>来源页面， 可多选，用 “,” 隔开的 String</p>
        /// </summary>
        [JsonProperty("From")]
        public string From{ get; set; }

        /// <summary>
        /// <p>日志等级</p>
        /// </summary>
        [JsonProperty("Level")]
        public string Level{ get; set; }

        /// <summary>
        /// <p>品牌</p>
        /// </summary>
        [JsonProperty("Brand")]
        public string Brand{ get; set; }

        /// <summary>
        /// <p>地区</p>
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// <p>版本</p>
        /// </summary>
        [JsonProperty("VersionNum")]
        public string VersionNum{ get; set; }

        /// <summary>
        /// <p>平台</p>
        /// </summary>
        [JsonProperty("Platform")]
        public string Platform{ get; set; }

        /// <summary>
        /// <p>自定义3</p>
        /// </summary>
        [JsonProperty("ExtThird")]
        public string ExtThird{ get; set; }

        /// <summary>
        /// <p>自定义1</p>
        /// </summary>
        [JsonProperty("ExtFirst")]
        public string ExtFirst{ get; set; }

        /// <summary>
        /// <p>网络类型（1,2,3,4,5,100），1表示WIFI, 2表示2G, 3表示3G, 4表示4G, 5表示5G, 6表示6G, 100表示未知</p>
        /// </summary>
        [JsonProperty("NetType")]
        public string NetType{ get; set; }

        /// <summary>
        /// <p>机型</p>
        /// </summary>
        [JsonProperty("Device")]
        public string Device{ get; set; }

        /// <summary>
        /// <p>显示是否海外,1表示海外，0表示非海外；默认值为空，查询所有。</p>
        /// </summary>
        [JsonProperty("IsAbroad")]
        public string IsAbroad{ get; set; }

        /// <summary>
        /// <p>操作系统</p>
        /// </summary>
        [JsonProperty("Os")]
        public string Os{ get; set; }

        /// <summary>
        /// <p>浏览器</p>
        /// </summary>
        [JsonProperty("Browser")]
        public string Browser{ get; set; }

        /// <summary>
        /// <p>环境</p>
        /// </summary>
        [JsonProperty("Env")]
        public string Env{ get; set; }

        /// <summary>
        /// <p>group by 参数值枚举1:1m  2:5m  3:30m  4:1h<br> 5:1d</p>
        /// </summary>
        [JsonProperty("GroupByType")]
        public long? GroupByType{ get; set; }

        /// <summary>
        /// <p>1: 查询智研<br>0: 走旧逻辑，已下线，勿使用</p>
        /// </summary>
        [JsonProperty("IsNewData")]
        public long? IsNewData{ get; set; }

        /// <summary>
        /// <p>自定义4</p>
        /// </summary>
        [JsonProperty("ExtFourth")]
        public string ExtFourth{ get; set; }

        /// <summary>
        /// <p>自定义5</p>
        /// </summary>
        [JsonProperty("ExtFifth")]
        public string ExtFifth{ get; set; }

        /// <summary>
        /// <p>自定义6</p>
        /// </summary>
        [JsonProperty("ExtSixth")]
        public string ExtSixth{ get; set; }

        /// <summary>
        /// <p>自定义7</p>
        /// </summary>
        [JsonProperty("ExtSeventh")]
        public string ExtSeventh{ get; set; }

        /// <summary>
        /// <p>自定义8</p>
        /// </summary>
        [JsonProperty("ExtEighth")]
        public string ExtEighth{ get; set; }

        /// <summary>
        /// <p>自定义9</p>
        /// </summary>
        [JsonProperty("ExtNinth")]
        public string ExtNinth{ get; set; }

        /// <summary>
        /// <p>自定义10</p>
        /// </summary>
        [JsonProperty("ExtTenth")]
        public string ExtTenth{ get; set; }

        /// <summary>
        /// <p>时间段</p>
        /// </summary>
        [JsonProperty("Granularity")]
        public string Granularity{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "ExtSecond", this.ExtSecond);
            this.SetParamSimple(map, prefix + "Engine", this.Engine);
            this.SetParamSimple(map, prefix + "Isp", this.Isp);
            this.SetParamSimple(map, prefix + "From", this.From);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "Brand", this.Brand);
            this.SetParamSimple(map, prefix + "Area", this.Area);
            this.SetParamSimple(map, prefix + "VersionNum", this.VersionNum);
            this.SetParamSimple(map, prefix + "Platform", this.Platform);
            this.SetParamSimple(map, prefix + "ExtThird", this.ExtThird);
            this.SetParamSimple(map, prefix + "ExtFirst", this.ExtFirst);
            this.SetParamSimple(map, prefix + "NetType", this.NetType);
            this.SetParamSimple(map, prefix + "Device", this.Device);
            this.SetParamSimple(map, prefix + "IsAbroad", this.IsAbroad);
            this.SetParamSimple(map, prefix + "Os", this.Os);
            this.SetParamSimple(map, prefix + "Browser", this.Browser);
            this.SetParamSimple(map, prefix + "Env", this.Env);
            this.SetParamSimple(map, prefix + "GroupByType", this.GroupByType);
            this.SetParamSimple(map, prefix + "IsNewData", this.IsNewData);
            this.SetParamSimple(map, prefix + "ExtFourth", this.ExtFourth);
            this.SetParamSimple(map, prefix + "ExtFifth", this.ExtFifth);
            this.SetParamSimple(map, prefix + "ExtSixth", this.ExtSixth);
            this.SetParamSimple(map, prefix + "ExtSeventh", this.ExtSeventh);
            this.SetParamSimple(map, prefix + "ExtEighth", this.ExtEighth);
            this.SetParamSimple(map, prefix + "ExtNinth", this.ExtNinth);
            this.SetParamSimple(map, prefix + "ExtTenth", this.ExtTenth);
            this.SetParamSimple(map, prefix + "Granularity", this.Granularity);
        }
    }
}

