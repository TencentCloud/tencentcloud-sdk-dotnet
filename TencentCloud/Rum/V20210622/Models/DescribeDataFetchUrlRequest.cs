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

    public class DescribeDataFetchUrlRequest : AbstractModel
    {
        
        /// <summary>
        /// 开始时间
        /// </summary>
        [JsonProperty("StartTime")]
        public long? StartTime{ get; set; }

        /// <summary>
        /// allcount：性能视图，pagepv：pv视图，day：14天数据，count40x：40X视图，count50x：50X视图，count5xand4x：40∑50视图，top：资源top视图，nettype/version/platform/isp/region/device/browser/ext1/ext2/ext3/ret/status/from/url/env/：网络平台视图/Version视图/设备视图/ISP视图/地区视图/浏览器视图/ext1视图等等
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [JsonProperty("EndTime")]
        public long? EndTime{ get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("ID")]
        public long? ID{ get; set; }

        /// <summary>
        /// 自定义2
        /// </summary>
        [JsonProperty("ExtSecond")]
        public string ExtSecond{ get; set; }

        /// <summary>
        /// 浏览器引擎
        /// </summary>
        [JsonProperty("Engine")]
        public string Engine{ get; set; }

        /// <summary>
        /// 运营商
        /// </summary>
        [JsonProperty("Isp")]
        public string Isp{ get; set; }

        /// <summary>
        /// 来源页面
        /// </summary>
        [JsonProperty("From")]
        public string From{ get; set; }

        /// <summary>
        /// 日志等级
        /// </summary>
        [JsonProperty("Level")]
        public string Level{ get; set; }

        /// <summary>
        /// 品牌
        /// </summary>
        [JsonProperty("Brand")]
        public string Brand{ get; set; }

        /// <summary>
        /// 地区
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// 版本
        /// </summary>
        [JsonProperty("VersionNum")]
        public string VersionNum{ get; set; }

        /// <summary>
        /// 平台
        /// </summary>
        [JsonProperty("Platform")]
        public string Platform{ get; set; }

        /// <summary>
        /// 自定义3
        /// </summary>
        [JsonProperty("ExtThird")]
        public string ExtThird{ get; set; }

        /// <summary>
        /// 自定义1
        /// </summary>
        [JsonProperty("ExtFirst")]
        public string ExtFirst{ get; set; }

        /// <summary>
        /// 网络类型
        /// </summary>
        [JsonProperty("NetType")]
        public string NetType{ get; set; }

        /// <summary>
        /// 机型
        /// </summary>
        [JsonProperty("Device")]
        public string Device{ get; set; }

        /// <summary>
        /// 显示是否海外,1表示海外，0表示非海外；默认值为空，查询所有。
        /// </summary>
        [JsonProperty("IsAbroad")]
        public string IsAbroad{ get; set; }

        /// <summary>
        /// 操作系统
        /// </summary>
        [JsonProperty("Os")]
        public string Os{ get; set; }

        /// <summary>
        /// 浏览器
        /// </summary>
        [JsonProperty("Browser")]
        public string Browser{ get; set; }

        /// <summary>
        /// 耗时计算方式
        /// </summary>
        [JsonProperty("CostType")]
        public string CostType{ get; set; }

        /// <summary>
        /// 来源
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// 环境
        /// </summary>
        [JsonProperty("Env")]
        public string Env{ get; set; }

        /// <summary>
        /// httpcode响应码
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// retcode
        /// </summary>
        [JsonProperty("Ret")]
        public string Ret{ get; set; }

        /// <summary>
        /// 网络状态
        /// </summary>
        [JsonProperty("NetStatus")]
        public string NetStatus{ get; set; }


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
            this.SetParamSimple(map, prefix + "CostType", this.CostType);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "Env", this.Env);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Ret", this.Ret);
            this.SetParamSimple(map, prefix + "NetStatus", this.NetStatus);
        }
    }
}

