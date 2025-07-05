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

namespace TencentCloud.As.V20180419.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AutoScalingNotification : AbstractModel
    {
        
        /// <summary>
        /// 伸缩组ID。
        /// </summary>
        [JsonProperty("AutoScalingGroupId")]
        public string AutoScalingGroupId{ get; set; }

        /// <summary>
        /// 用户组ID列表。
        /// </summary>
        [JsonProperty("NotificationUserGroupIds")]
        public string[] NotificationUserGroupIds{ get; set; }

        /// <summary>
        /// 通知事件列表。取值范围如下:
        /// <li>SCALE_OUT_SUCCESSFUL：扩容成功</li>
        /// <li>SCALE_OUT_FAILED：扩容失败</li>
        /// <li>SCALE_IN_SUCCESSFUL：缩容成功</li>
        /// <li>SCALE_IN_FAILED：缩容失败</li>
        /// <li>REPLACE_UNHEALTHY_INSTANCE_SUCCESSFUL：替换不健康子机成功</li>
        /// <li>REPLACE_UNHEALTHY_INSTANCE_FAILED：替换不健康子机失败</li>
        /// </summary>
        [JsonProperty("NotificationTypes")]
        public string[] NotificationTypes{ get; set; }

        /// <summary>
        /// 事件通知ID。
        /// </summary>
        [JsonProperty("AutoScalingNotificationId")]
        public string AutoScalingNotificationId{ get; set; }

        /// <summary>
        /// 通知接收端类型。取值范围如下：
        /// USER_GROUP：用户组
        /// TDMQ_CMQ_TOPIC：TDMQ CMQ 主题
        /// TDMQ_CMQ_QUEUE：TDMQ CMQ 队列
        /// CMQ_QUEUE：CMQ 队列，[CMQ 接口已下线](https://cloud.tencent.com/document/product/1496/83970)，已无法选用
        /// CMQ_TOPIC：CMQ 主题，[CMQ 接口已下线](https://cloud.tencent.com/document/product/1496/83970)，已无法选用
        /// </summary>
        [JsonProperty("TargetType")]
        public string TargetType{ get; set; }

        /// <summary>
        /// TDMQ CMQ 队列名。
        /// </summary>
        [JsonProperty("QueueName")]
        public string QueueName{ get; set; }

        /// <summary>
        /// TDMQ CMQ 主题名。
        /// </summary>
        [JsonProperty("TopicName")]
        public string TopicName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AutoScalingGroupId", this.AutoScalingGroupId);
            this.SetParamArraySimple(map, prefix + "NotificationUserGroupIds.", this.NotificationUserGroupIds);
            this.SetParamArraySimple(map, prefix + "NotificationTypes.", this.NotificationTypes);
            this.SetParamSimple(map, prefix + "AutoScalingNotificationId", this.AutoScalingNotificationId);
            this.SetParamSimple(map, prefix + "TargetType", this.TargetType);
            this.SetParamSimple(map, prefix + "QueueName", this.QueueName);
            this.SetParamSimple(map, prefix + "TopicName", this.TopicName);
        }
    }
}

