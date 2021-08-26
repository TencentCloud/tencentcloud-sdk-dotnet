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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RecordParam : AbstractModel
    {
        
        /// <summary>
        /// 录制间隔。
        /// 单位秒，默认：1800。
        /// 取值范围：30-7200。
        /// 此参数对 HLS 无效，当录制 HLS 时从推流到断流生成一个文件。
        /// </summary>
        [JsonProperty("RecordInterval")]
        public long? RecordInterval{ get; set; }

        /// <summary>
        /// 录制存储时长。
        /// 单位秒，取值范围： 0 - 1500天。
        /// 0：表示永久存储。
        /// </summary>
        [JsonProperty("StorageTime")]
        public long? StorageTime{ get; set; }

        /// <summary>
        /// 是否开启当前格式录制，默认值为0，0：否， 1：是。
        /// </summary>
        [JsonProperty("Enable")]
        public long? Enable{ get; set; }

        /// <summary>
        /// 点播子应用 ID。
        /// </summary>
        [JsonProperty("VodSubAppId")]
        public long? VodSubAppId{ get; set; }

        /// <summary>
        /// 录制文件名。
        /// 支持的特殊占位符有：
        /// {StreamID}: 流ID
        /// {StartYear}: 开始时间-年
        /// {StartMonth}: 开始时间-月
        /// {StartDay}: 开始时间-日
        /// {StartHour}: 开始时间-小时
        /// {StartMinute}: 开始时间-分钟
        /// {StartSecond}: 开始时间-秒
        /// {StartMillisecond}: 开始时间-毫秒
        /// {EndYear}: 结束时间-年
        /// {EndMonth}: 结束时间-月
        /// {EndDay}: 结束时间-日
        /// {EndHour}: 结束时间-小时
        /// {EndMinute}: 结束时间-分钟
        /// {EndSecond}: 结束时间-秒
        /// {EndMillisecond}: 结束时间-毫秒
        /// 
        /// 若未设置默认录制文件名为{StreamID}_{StartYear}-{StartMonth}-{StartDay}-{StartHour}-{StartMinute}-{StartSecond}_{EndYear}-{EndMonth}-{EndDay}-{EndHour}-{EndMinute}-{EndSecond}
        /// </summary>
        [JsonProperty("VodFileName")]
        public string VodFileName{ get; set; }

        /// <summary>
        /// 任务流
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Procedure")]
        public string Procedure{ get; set; }

        /// <summary>
        /// 视频存储策略。
        /// normal：标准存储。
        /// cold：低频存储。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StorageMode")]
        public string StorageMode{ get; set; }

        /// <summary>
        /// 点播应用分类
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClassId")]
        public long? ClassId{ get; set; }


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
        }
    }
}

