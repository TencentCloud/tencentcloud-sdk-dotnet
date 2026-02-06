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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateDlcDeliverRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>日志主题id。</p><ul><li>通过<a href="https://cloud.tencent.com/document/product/614/56454">获取日志主题列表</a>获取日志主题Id。</li></ul>
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// <p>名称：长度不超过64字符，以字母开头，接受0-9,a-z,A-Z, _,-,中文字符。</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>投递类型。0:批投递,1:实时投递</p>
        /// </summary>
        [JsonProperty("DeliverType")]
        public ulong? DeliverType{ get; set; }

        /// <summary>
        /// <p>投递时间范围的开始时间</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public ulong? StartTime{ get; set; }

        /// <summary>
        /// <p>dlc配置信息</p>
        /// </summary>
        [JsonProperty("DlcInfo")]
        public DlcInfo DlcInfo{ get; set; }

        /// <summary>
        /// <p>投递文件大小,单位MB。 DeliverType=0时必填，范围 5&lt;= MaxSize &lt;= 256。</p>
        /// </summary>
        [JsonProperty("MaxSize")]
        public ulong? MaxSize{ get; set; }

        /// <summary>
        /// <p>投递间隔，单位秒。 DeliverType=0时必填，范围 300&lt;= Interval &lt;=900。</p>
        /// </summary>
        [JsonProperty("Interval")]
        public ulong? Interval{ get; set; }

        /// <summary>
        /// <p>投递时间范围的结束时间。 如果为空，则表示不限时。EndTime不为空时，需要大于StartTime。</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public ulong? EndTime{ get; set; }

        /// <summary>
        /// <p>是否开启投递服务日志。1关闭，2开启。默认开启</p>
        /// </summary>
        [JsonProperty("HasServicesLog")]
        public ulong? HasServicesLog{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "DeliverType", this.DeliverType);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamObj(map, prefix + "DlcInfo.", this.DlcInfo);
            this.SetParamSimple(map, prefix + "MaxSize", this.MaxSize);
            this.SetParamSimple(map, prefix + "Interval", this.Interval);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "HasServicesLog", this.HasServicesLog);
        }
    }
}

