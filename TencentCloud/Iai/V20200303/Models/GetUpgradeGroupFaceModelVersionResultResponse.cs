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

namespace TencentCloud.Iai.V20200303.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetUpgradeGroupFaceModelVersionResultResponse : AbstractModel
    {
        
        /// <summary>
        /// 人员升级任务预估结束时间。 StartTimestamp的值是自 Unix 纪元时间到人员查重任务预估结束的毫秒数。  
        /// Unix 纪元时间是 1970 年 1 月 1 日星期四，协调世界时 (UTC) 00:00:00。 
        /// 如果为0表示这个任务已经执行完毕。
        /// </summary>
        [JsonProperty("EndTimestamp")]
        public ulong? EndTimestamp{ get; set; }

        /// <summary>
        /// 升级任务完成进度。取值[0.0，100.0]。
        /// </summary>
        [JsonProperty("Progress")]
        public float? Progress{ get; set; }

        /// <summary>
        /// 0表示升级中，1表示升级完毕，2表示回滚完毕，3表示升级失败。
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 升级起始时间。 
        /// StartTime的值是自 Unix 纪元时间到Group创建时间的毫秒数。 
        /// Unix 纪元时间是 1970 年 1 月 1 日星期四，协调世界时 (UTC) 00:00:00。 
        /// 有关更多信息，请参阅 Unix 时间。
        /// </summary>
        [JsonProperty("StartTime")]
        public ulong? StartTime{ get; set; }

        /// <summary>
        /// 当前算法模型版本。
        /// </summary>
        [JsonProperty("FromFaceModelVersion")]
        public string FromFaceModelVersion{ get; set; }

        /// <summary>
        /// 目标算法模型版本。
        /// </summary>
        [JsonProperty("ToFaceModelVersion")]
        public string ToFaceModelVersion{ get; set; }

        /// <summary>
        /// 人员库ID。
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// 无法升级的人脸Id信息，文件格式为json。内容参见下方示例。url有效期为半小时。
        /// </summary>
        [JsonProperty("FailedFacesUrl")]
        public string FailedFacesUrl{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EndTimestamp", this.EndTimestamp);
            this.SetParamSimple(map, prefix + "Progress", this.Progress);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "FromFaceModelVersion", this.FromFaceModelVersion);
            this.SetParamSimple(map, prefix + "ToFaceModelVersion", this.ToFaceModelVersion);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "FailedFacesUrl", this.FailedFacesUrl);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

