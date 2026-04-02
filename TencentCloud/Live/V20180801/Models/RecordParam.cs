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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RecordParam : AbstractModel
    {
        
        /// <summary>
        /// <p>录制间隔。<br>单位秒，默认：1800。<br>FLV、MP4取值范围： 60-43200， AAC取值范围： 60-7200 。<br>此参数对 HLS 无效，当录制 HLS 时从推流到断流生成一个文件。</p>
        /// </summary>
        [JsonProperty("RecordInterval")]
        public long? RecordInterval{ get; set; }

        /// <summary>
        /// <p>录制存储时长。<br>单位秒，取值范围： 0 - 1500天。<br>0：表示永久存储。<br>注：此参数只对录制到VOD有效。</p>
        /// </summary>
        [JsonProperty("StorageTime")]
        public long? StorageTime{ get; set; }

        /// <summary>
        /// <p>是否开启当前格式录制，默认值为0，0：否， 1：是。</p>
        /// </summary>
        [JsonProperty("Enable")]
        public long? Enable{ get; set; }

        /// <summary>
        /// <p>点播子应用 ID。</p>
        /// </summary>
        [JsonProperty("VodSubAppId")]
        public long? VodSubAppId{ get; set; }

        /// <summary>
        /// <p>录制文件名。<br>支持的特殊占位符有：<br>{StreamID}: 流ID<br>{StartYear}: 开始时间-年<br>{StartMonth}: 开始时间-月<br>{StartDay}: 开始时间-日<br>{StartHour}: 开始时间-小时<br>{StartMinute}: 开始时间-分钟<br>{StartSecond}: 开始时间-秒<br>{StartMillisecond}: 开始时间-毫秒<br>{EndYear}: 结束时间-年<br>{EndMonth}: 结束时间-月<br>{EndDay}: 结束时间-日<br>{EndHour}: 结束时间-小时<br>{EndMinute}: 结束时间-分钟<br>{EndSecond}: 结束时间-秒<br>{EndMillisecond}: 结束时间-毫秒</p><p>若未设置默认录制文件名为{StreamID}_{StartYear}-{StartMonth}-{StartDay}-{StartHour}-{StartMinute}-{StartSecond}_{EndYear}-{EndMonth}-{EndDay}-{EndHour}-{EndMinute}-{EndSecond}</p>
        /// </summary>
        [JsonProperty("VodFileName")]
        public string VodFileName{ get; set; }

        /// <summary>
        /// <p>任务流</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Procedure")]
        public string Procedure{ get; set; }

        /// <summary>
        /// <p>视频存储策略。<br>normal：标准存储。<br>cold：低频存储。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StorageMode")]
        public string StorageMode{ get; set; }

        /// <summary>
        /// <p>点播应用分类</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClassId")]
        public long? ClassId{ get; set; }

        /// <summary>
        /// <p>存储至 cos 的 bucket 桶名称。<br>注：CosBucketName参数值不能包含-[appid] 部分。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CosBucketName")]
        public string CosBucketName{ get; set; }

        /// <summary>
        /// <p>存储至 cos 的 bucket 区域。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CosBucketRegion")]
        public string CosBucketRegion{ get; set; }

        /// <summary>
        /// <p>存储至 cos 的 bucket 路径。<br>注意：若为输入参数，则该参数必填，且必须以斜杠（/）开头，建议至少包含 {StartYear}、{StartMonth}、{StartDay}、{StartHour}、{StartMinute}、{StartSecond} 或 {RandomID} 任意一种，否则可能出现录制文件名重复造成文件相互覆盖；若为返回参数，则此字段可能返回 null，表示取不到有效值。<br>示例值：/{RecordSource}/{Domain}/{AppName}/{StreamID}/{RecordId}-{RandomID}/{StartYear}-{StartMonth}-{StartDay}-{StartHour}-{StartMinute}-{StartSecond}</p><p>支持的特殊占位符有：<br>{RecordSource}：区分录制内容，若录制原始流、水印流则为“origin”，录制转码流时，代表转码模板ID<br>{StreamID}: 流ID<br>{RecordId}：录制任务ID，断流前后该值可能重复；<br>{RandomID}：随机数，断流前后该值不同；<br>{StartYear}: 开始时间-年<br>{StartMonth}: 开始时间-月<br>{StartDay}: 开始时间-日<br>{StartHour}: 开始时间-小时<br>{StartMinute}: 开始时间-分钟<br>{StartSecond}: 开始时间-秒<br>{StartMillisecond}: 开始时间-毫秒<br>{EndYear}: 结束时间-年<br>{EndMonth}: 结束时间-月<br>{EndDay}: 结束时间-日<br>{EndHour}: 结束时间-小时<br>{EndMinute}: 结束时间-分钟<br>{EndSecond}: 结束时间-秒<br>{EndMillisecond}: 结束时间-毫秒</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CosBucketPath")]
        public string CosBucketPath{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RecordInterval", this.RecordInterval);
            this.SetParamSimple(map, prefix + "StorageTime", this.StorageTime);
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "VodSubAppId", this.VodSubAppId);
            this.SetParamSimple(map, prefix + "VodFileName", this.VodFileName);
            this.SetParamSimple(map, prefix + "Procedure", this.Procedure);
            this.SetParamSimple(map, prefix + "StorageMode", this.StorageMode);
            this.SetParamSimple(map, prefix + "ClassId", this.ClassId);
            this.SetParamSimple(map, prefix + "CosBucketName", this.CosBucketName);
            this.SetParamSimple(map, prefix + "CosBucketRegion", this.CosBucketRegion);
            this.SetParamSimple(map, prefix + "CosBucketPath", this.CosBucketPath);
        }
    }
}

