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

namespace TencentCloud.Cr.V20180321.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTaskStatusResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>任务结果：</p><ul style="margin-bottom:0px;"><li>处理中："Uploading Data."</li><li>上传成功："File Uploading Task Success."</li><li>上传失败：具体失败原因</li></ul>
        /// </summary>
        [JsonProperty("TaskResult")]
        public string TaskResult{ get; set; }

        /// <summary>
        /// <p>任务类型：</p><ul style="margin-bottom:0px;"><li>到期/逾期提醒数据上传：002</li><li>到期/逾期提醒停拨数据上传：003</li><li>回访数据上传：004</li><li>回访停拨数据上传：005</li></ul>
        /// </summary>
        [JsonProperty("TaskType")]
        public string TaskType{ get; set; }

        /// <summary>
        /// 过滤文件下载链接，有过滤数据时才存在。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskFileUrl")]
        public string TaskFileUrl{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskResult", this.TaskResult);
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamSimple(map, prefix + "TaskFileUrl", this.TaskFileUrl);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

